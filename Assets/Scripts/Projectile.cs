using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public bool doesBounce = false;


    public ProjectileType projectileType;
    public ProjectilePath projectilePath;


    Vector2 collisionNormal;
    Vector2 direction2D;

    public WeaponInfo currentWeaponInfo = null;


    public Vector3 direction;

    public int damage;
    float despawnTime;
    float magnitude;
    int numberOfBounces;

    float splashRadius;
    int splashDamage;

    bool exploding = false;
    bool isSpawning = true;


    CapsuleCollider caster;
    SphereCollider thisProjectileCollider;

    private void Start()
    {
        //caster = GetComponent<CapsuleCollider>();
        //thisProjectileCollider = GetComponent<SphereCollider>();
        //Physics.IgnoreCollision(thisProjectileCollider, caster);


        damage = currentWeaponInfo.damage;

        splashDamage = currentWeaponInfo.splashDamage;

        splashRadius = currentWeaponInfo.splashDamageRadius;

        numberOfBounces = currentWeaponInfo.numberOfBounces;

        magnitude = currentWeaponInfo.projectileSpeed;

        despawnTime = currentWeaponInfo.timeBeforeDespawn;

        Destroy(gameObject, despawnTime);
    }




    private void FixedUpdate()
    {

        this.gameObject.GetComponent<Rigidbody>().velocity = direction * magnitude;

    }


    private void OnCollisionEnter(Collision collision)
    {


        if (collision.gameObject.tag == "Enemy")
        {
            collision.gameObject.GetComponent<EnemyBehavior>().TakeDamage(damage);
            DealSplashDamage();
            Destroy(gameObject);
        }

        
        if(collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerInfo>().TakeDamage(damage);
            DealSplashDamage();
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "DestroyableObject") { collision.gameObject.GetComponent<DestroyableObject>().TakeDamage(damage); }
        
        
        if (numberOfBounces <= 0 || collision.gameObject.tag == "Projectile") { DealSplashDamage(); Destroy(gameObject); }


        if (numberOfBounces > 0)
        {
            collisionNormal = new Vector2(collision.contacts[0].normal.x, collision.contacts[0].normal.z).normalized;

            direction2D = (new Vector2(direction.x, direction.z));

            direction2D = (direction2D - 2 * (Vector2.Dot(direction2D, collisionNormal)) * collisionNormal);

            direction = new Vector3(direction2D.x, 0, direction2D.y);
            numberOfBounces--;

        }


    }

    private void DealSplashDamage()
    {
        //checks surrounding area in a sphere
        var collidersHit = Physics.OverlapSphere(gameObject.transform.position, splashRadius);
        
        
        for (int i = 0; i < collidersHit.Length; i++)
        {

            collidersHit[i].gameObject.TryGetComponent<EntityInfo>(out EntityInfo entityInfo);
            if (entityInfo != null)
            {
                Debug.Log("SPLASH DMG");
                //We deal splash damage if what we hit is not null
                entityInfo.TakeDamage(splashDamage);
            }
            
        }

        exploding = true;
    }

    private void OnDrawGizmos()
    {
        if (exploding)
        {
            //Draws splash damage radius
            Gizmos.color = Color.red;
            Gizmos.DrawSphere(gameObject.transform.position, splashRadius);
        }
    }


}
