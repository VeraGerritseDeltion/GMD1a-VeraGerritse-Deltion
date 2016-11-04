using UnityEngine;
using System.Collections;

public class Start : MonoBehaviour {
    public Vector3 dir;
    public Rigidbody bal;
    public bool j;


    // Update is called once per frame
    void Update()
    {
        if (j == true && Input.GetKey(KeyCode.A))
        {



            bal.AddForce(dir * -80);
        }

        if (Input.GetKey(KeyCode.A)) { 
        j = false;
            }
    
    }

public void OnCollisionEnter(Collision collision)
{
        j = true;

    dir = collision.contacts[0].point;
   

}
}
