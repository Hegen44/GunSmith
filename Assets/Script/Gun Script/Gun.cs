using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Gun: MonoBehaviour
{
    public string Name;
    public float Weight;

    public int magazinesize;
    public int damage;
    public float reloadspeed;
    public float ammo;
    public float spread;
    public float firerate;
    public int magzine;
    public float range;
    public float recoil;

    public GameObject bullet;

    public virtual void shoot(vector3 p, Quaternion r)
    {
        Instantiate(bullet, p, r);
    }

    public virtual void reload()
    {
        magzine = magazinesize;
    }
}