using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer : MonoBehaviour {

    public GameObject bulletParent;
    public Transform bulletSpawn;
    public float bulletTimer;
    public float bulletSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        if(Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
        
    }

    public void Shoot()
    {
        GameObject bullet = Instantiate(bulletParent, bulletSpawn.position, bulletSpawn.rotation);
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * bulletSpeed;

        Destroy(bullet, bulletTimer);

    }
}
