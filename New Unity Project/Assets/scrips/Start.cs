using UnityEngine;
using System.Collections;

public class Start : MonoBehaviour {
    public Vector3 dir;
    public Rigidbody bal;
	
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnCollisionEnter(Collision collision)
    {
        dir = collision.contacts[0].point;

     
            bal.AddForce(dir * -191);
        
    }
}
