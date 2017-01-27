using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Shot : MonoBehaviour {
    public float handen;
    public float tijd;
    public Text tekst;
    public bool coli;
    public Vector2 dir;
    public Rigidbody bal;

	
	void Update () {
        
        // start timer       
        if (Input.GetButton("Jump") && coli == true)
        {
            handen = handen + 1;
            tijd = Time.deltaTime * handen;
        }
        //combinatie van spatiebalk en timer geeft force
        if (tijd < 0.2f && coli == true && Input.GetButtonUp("Jump"))
        {
            bal.AddForce(dir * -10);
            handen = 0;
            tijd = 0;
            coli = false;
        }
        

        if (tijd > 0.2f && tijd < 0.5f && coli == true && Input.GetButtonUp("Jump"))
        {
            bal.AddForce(dir * -20);
            handen = 0;
            tijd = 0;
            coli = false;
        }

        if (tijd > 0.5f && tijd < 0.7f && coli == true&& Input.GetButtonUp("Jump"))
        {
            bal.AddForce(dir * -40);
            handen = 0;
            tijd = 0;
        }

        if (tijd > 0.7f && tijd < 1 && coli == true&& Input.GetButtonUp("Jump"))
        {
            bal.AddForce(dir * -60);
            handen = 0;
            tijd = 0;
            coli = false;
        }

        if (tijd > 1 && tijd < 1.3 && coli == true&& Input.GetButtonUp("Jump"))
        {
            bal.AddForce(dir * -80);
            handen = 0;
            tijd = 0;
            coli = false;
        }

        if (tijd > 1.3f  && Input.GetButtonUp("Jump") && coli == true)
        {
            bal.AddForce(dir * -100);
            handen = 0;
            tijd = 0;
            coli = false;
        }
       
    }
    public void OnCollisionEnter (Collision collision)
    {//alleen schieten als bal bij start is
        if (collision.collider.tag == "Player")
        {
            coli = true;
            dir = collision.contacts[0].point;
            // bij start deur open
            Bal.door = false;
        }
        
    }
    
}
