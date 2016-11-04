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
        dir = collision.contacts[0].normal;
        bal.AddForce(dir * -200);
    }
}
