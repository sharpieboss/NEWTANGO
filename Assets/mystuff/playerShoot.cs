using UnityEngine;

using System.Collections;

 

public class playerShoot : MonoBehaviour 
{   

    void Update () 

    {

        Object bullet = GameObject.FindWithTag("bullet");

            if(Input.GetButtonDown("Fire1"))
            {
                GameObject muzzle = GameObject.FindWithTag("Player");
                Object clone = Instantiate(bullet, muzzle.transform.position, muzzle.transform.rotation);

            }

    }

}