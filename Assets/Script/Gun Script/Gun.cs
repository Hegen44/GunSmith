using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Gun : MonoBehaviour
{

    public GameObject bullet;

    private string _name;
    private float _weight;
    private int _tier;
    private int _magazinesize;
    private int _damage;
    private float _reloadspeed;
    private float _ammo;
    private float _spread;
    private float _firerate;
    private int _ammocount;
    private float _range;
    private float _recoil;


    #region setter and getter

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public float Weight
    {
        get { return _weight; }
        set { _weight = value; }
    }

    public int tier
    {
        get { return _tier; }
        set { _tier = value; }
    }
    public int magazinesize
    {
        get { return _magazinesize; }
        set { _magazinesize = value; }
    }
    public int damage
    {
        get { return _damage; }
        set { _damage = value; }
    }
    public float reloadspeed
    {
        get { return _reloadspeed; }
        set { _reloadspeed = value; }
    }
    public float ammo
    {
        get { return _ammo; }
        set { _ammo = value; }
    }
    public float spread
    {
        get { return _spread; }
        set { _spread = value; }
    }
    public float fireRate
    {
        get { return _firerate; }
        set { _firerate = value; }
    }
    public int ammocount
    {
        get { return _ammocount; }
        set { _ammocount = value; }
    }
    public float range
    {
        get { return _range; }
        set { _range = value; }
    }
    public float recoil
    {
        get { return _recoil; }
        set { _recoil = value; }
    }
    #endregion

    public virtual void shoot(Vector3 p, Quaternion r)
    {
        Instantiate(this.bullet, p, r);
    }

    public virtual void reload()
    {
        this.ammocount = this.magazinesize;
    }

    public virtual void Init()
    {

    }
}