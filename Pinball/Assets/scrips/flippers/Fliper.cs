using UnityEngine;
using System.Collections;

public class Fliper : MonoBehaviour {
    public Vector3 dir;
    public Rigidbody bal;
    public bool force;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void OnCollisionEnter (Collision collision)
    {//als flipper omhoog gaat kan er force zijn
        if(Flipper.acfl == true)
        {
            force = true;
        }
           
        // apply force
        if (force == true)
        {
            dir = collision.contacts[0].normal;
            bal.AddForce(dir * -300);
        }
        force = false;
    }
}
