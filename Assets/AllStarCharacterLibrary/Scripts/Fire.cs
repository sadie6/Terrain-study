using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour {


    public GameObject bullet;
    public float speed;
	
	void Update () {
        if (Input.GetMouseButtonDown(1))
        {
            GameObject newbullet  = Instantiate(bullet, transform.position, transform.rotation);
            newbullet.GetComponent<Rigidbody>().velocity = transform.forward * speed;
            Physics.IgnoreCollision(transform.root.GetComponent<Collider>(), newbullet.GetComponent<Collider>(), true);
            Destroy(newbullet,3.0f);
        }
	}

}
