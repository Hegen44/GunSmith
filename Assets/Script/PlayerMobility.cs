using UnityEngine;
using System.Collections;

public class PlayerMobility : Gun
{

    void FixedUpdate()
    {
        var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Quaternion rot = Quaternion.LookRotation( transform.position - mousePosition, transform.forward);

        transform.rotation = rot;
        transform.localEulerAngles = new Vector3(0, 0, transform.localEulerAngles.z);
    }
}
