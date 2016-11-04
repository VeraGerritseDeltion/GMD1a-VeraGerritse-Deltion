using UnityEngine;
using System.Collections;

public class force : MonoBehaviour {
    public Vector3 dir;
    public Rigidbody bal;
    public bool forcee;
   
    public void OnCollisionEnter(Collision collision)
    {
        if (Flipperrechts.flip == true)
        {
            forcee = true;
        }


        if (forcee == true)
        {
            dir = collision.contacts[0].normal;
            bal.AddForce(dir * -300);
        }
        forcee = false;
    }
}
