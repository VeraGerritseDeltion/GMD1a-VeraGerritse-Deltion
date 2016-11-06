using UnityEngine;
using System.Collections;

public class Bump : MonoBehaviour {
    public Rigidbody bal;
    public Vector3 dir;
    public AudioSource bumper1;
    public AudioSource bumper2;
    public AudioSource bumper3;
    public AudioSource bumper4;
    public int randomizer;
    public int random;
    public static bool rans;


	
	// Update is called once per frame
	void Update () {

       // random sound
        randomizer = randomizer + 1;
        if(randomizer > 4)
        {
            randomizer = 1;
        }
        if (rans == true)
        {
            random = randomizer;
            rans = false;
        }
        if (random == 1)
        {
            AudioSource bumper = GetComponent<AudioSource>();
            bumper1.Play();
        }
        if (random == 2)
        {
            AudioSource bumper = GetComponent<AudioSource>();
            bumper2.Play();
        }
        if (random == 3)
        {
            AudioSource bumper = GetComponent<AudioSource>();
            bumper3.Play();
        }
        if (random >= 4)
        {
            AudioSource bumper = GetComponent<AudioSource>();
            bumper4.Play();
        }


    }
    public void OnCollisionEnter(Collision collision)
    { // force bumpers
        dir = collision.contacts[0].normal;
        bal.AddForce(dir * -200);
        //start random
        rans = true;
    }
}
