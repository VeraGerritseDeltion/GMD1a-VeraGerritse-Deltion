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

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonUp("Jump"))
        {
            print(tijd);
        }
        if (Input.GetAxis("Jump")> 0 && coli == true)
        {
            handen = handen + 1;
            tijd = Time.deltaTime * handen;
        }

        if (tijd < 0.5f && Input.GetButtonUp("Jump"))
        {
            bal.AddForce(dir * -10);
            handen = 0;
            tijd = 0;
        }


        if (tijd > 0.5f && tijd < 1 && Input.GetButtonUp("Jump"))
        {
            bal.AddForce(dir * -20);
            handen = 0;
            tijd = 0;
        }
        if (tijd > 1 && tijd < 1.5f && Input.GetButtonUp("Jump"))
        {
            bal.AddForce(dir * -40);
            handen = 0;
            tijd = 0;
        }
        if (tijd > 1.5f && tijd < 2 && Input.GetButtonUp("Jump"))
        {
            bal.AddForce(dir * -60);
            handen = 0;
            tijd = 0;
        }
        if (tijd > 2 && tijd < 2.5 && Input.GetButtonUp("Jump"))
        {
            bal.AddForce(dir * -80);
            handen = 0;
            tijd = 0;
        }
        if (tijd > 2.5f  && Input.GetButtonUp("Jump"))
        {
            bal.AddForce(dir * -100);
            handen = 0;
            tijd = 0;
        }
    }
    public void OnCollisionEnter (Collision collision)
    {
        coli = true;
        dir = collision.contacts[0].point;
    }
    
}
