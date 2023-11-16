using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosiveBarrel : DestroyableObject
{
    [SerializeField] private float FuseTime;

    [SerializeField] private Explosive explosive;
    private bool isDestroyed;

    [SerializeField] private GameObject meshObject;
    [SerializeField] private Material fuseMaterial;
    
    
    private Renderer render;

    // Start is called before the first frame update
    void Start()
    {

        if (!render)
        {
            render = meshObject.GetComponent<Renderer>();
        }

        isDestroyed = false;
        explosive = GetComponent<Explosive>();
    }

    public override void Die()
    {
        health= 0;
        if (!isDestroyed) 
        {
            isDestroyed= true;
            StartCoroutine(fuse());
            //explosive.Explode();
            //Destroy(gameObject);
        }
       
        //Custom explosion delete
    }

    private IEnumerator fuse()
    {
        if (fuseMaterial)
        {
            render.material = fuseMaterial;
        }

        //explosive.Explode();

        yield return new WaitForSeconds(FuseTime);

        //render.enabled = false;
        explosive.Explode();
        //yield return new WaitForSeconds(0.3f);
        Destroy(gameObject);

        yield return null;
    }
}
