using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DestroyProjectile : MonoBehaviour
{
    Projectile bullet;
    //ParticleSystem particleObject;
    UnityEngine.Object destroyedEffect;


    private SphereCollider coll;
    private Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        coll = GetComponent<SphereCollider>();
        rend = GetComponent<Renderer>();

        bullet = GetComponent<Projectile>();
        bullet.OnDestroyed += Bullet_OnDestroyed;

        destroyedEffect = Resources.Load("GunEffect");
        destroyedEffect.GetComponent<ParticleSystem>();

        //particleObject = GetComponentInChildren<ParticleSystem>();
        //particleObject.Stop();
    }

    private void Bullet_OnDestroyed(object sender, System.EventArgs e)
    {
        DisableComponents();
        //particleObject.Play();

        
        
       Object Effect = Instantiate(destroyedEffect, transform.position, Quaternion.identity);
        Destroy(Effect, 3f);

        //Destroy(gameObject, particleObject.duration);
        Destroy(gameObject);
    }

    private void DisableComponents()
    {
        //rend.enabled = false;
        //coll.enabled = false;
        bullet.direction = Vector3.zero;
    }
}