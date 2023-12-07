using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class WeaponBase : MonoBehaviour
{
    //Main components of each weapon.
    //These are aspects that each weapon will handle
    [SerializeField] protected WeaponSO stats;

    protected string weaponName;
    protected float fireRate;
    public float walkMultiplier;

    protected GameObject projectilePrefab;

    protected abstract void setStats();
}
