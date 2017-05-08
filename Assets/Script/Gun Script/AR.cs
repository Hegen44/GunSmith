using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AR : Gun {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    private float nextFire = 0.0F;

    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + this.fireRate;
            this.shoot(this.transform.position, this.transform.rotation);
        }
    }

    void init(string n, int v)
    {
        this.Name = n;
        this.Weight = Random.Range(0, 3);
        this.tier = v;
        this.magazinesize = Random.Range(0,3) * v;
        this.damage = Random.Range(0, 3) * v;
        this.reloadspeed = Random.Range(0, 3) * v;
        this.ammo = Random.Range(0, 3) * v;
        this.spread = Random.Range(0, 3) * v;
        this.fireRate = Random.Range(0, 3) * v;
        this.range = Random.Range(0, 3) * v;
        this.recoil = Random.Range(0, 3) * v;
    }
     /*

        //GunName.js
        var company = ["Johnson ", "Jefferson ", "Thompson ", " Nikosa "];
        var firstname = ["malicious ", "delicious ", "legendary "];
        var lastname = ["banana ", "waffle ", " kitten "];
        var type = ["smg", "lmg", "ar", "pistol"];
        var wepmanager : GameObject;
        var gui : GameObject;
        var gunname : String;
        var stats : String;
        var explosion : Transform;

        function Start(){
        wepmanager = gameObject.Find("weapons");
        gui = GameObject.Find("weptext");
        var i = Random.Range (0, company.Length);
        var j = Random.Range (0, firstname.Length);
        var k = Random.Range (0, lastname.Length);
        var l = Random.Range (0, type.Length);
        var damage = gameObject.GetComponent("ShootScript").damage;
        var rate = gameObject.GetComponent("ShootScript").delay;
        var accu = gameObject.GetComponent("ShootScript").shotSpread;
        var gunnum = wepmanager.transform.childCount;
        gunname = company[i]+firstname[j]+lastname[k]+type[l];
        stats = Mathf.Round(rate*10)/10+"-"+Mathf.Round(accu*10)/10+"-"+Mathf.Round(damage);

        transform.name=gunnum+"_"+gunname;

        }

        function FixedUpdate ()
        {
        gui.guiText.text=gunname + " ("+stats+")";

        }
    */
}
