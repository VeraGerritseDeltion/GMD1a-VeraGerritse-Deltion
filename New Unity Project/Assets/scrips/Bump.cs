using UnityEngine;
using System.Collections;

public class Bump : MonoBehaviour {
    public Rigidbody bal;
        public Vector3 dir;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
       

    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "bumpers")
        bal.AddForce(dir * -500);
    dir = collision.contacts[0].point;
    }
}
