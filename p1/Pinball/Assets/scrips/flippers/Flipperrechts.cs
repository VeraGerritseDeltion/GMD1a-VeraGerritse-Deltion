using UnityEngine;
using System.Collections;

public class Flipperrechts : MonoBehaviour
{
    public static bool flip;
    public bool back;
    public float timer = 0;
    public float timer2 = 0;
    public GameObject flipperl;
    public Vector3 up;
    public Vector3 down;
    public Vector3 dir;
    public Rigidbody bal;

    
    void Start()
    {// start rotatie
        up.x = 21.128f;
        up.y = 24.818f;
        up.z = 9.732f;
        down.x = 23.188f;
        

    }

   
    void Update()
    {//als rechter muisklik indrukreset timer
        
        if (Input.GetButton("Fire2"))
        {
            flip = true;
            timer2 = 0;
        }
        //duur rotatie
        if (timer > 0.1f)
        {
            flip = false;
            transform.localEulerAngles = up;


        }
        // start timer en rotatie
        if (flip == true)
        {
            transform.RotateAround
                (transform.position, flipperl.transform.right, 200 * Time.deltaTime);
            timer = timer + Time.deltaTime;

        }
        // rechtermuis loslaten en reset timer
        if (Input.GetButtonUp("Fire2"))
        {
            back = true;
            timer = 0;
        }
        //duur rotatie
        if (timer2 > 0.1f)
        {
            back = false;
            transform.localEulerAngles = down;

        }
        //start timer en rotatie
        if (back == true)
        {
            transform.RotateAround
                (transform.position, flipperl.transform.right, -200 * Time.deltaTime);
            timer2 = timer2 + Time.deltaTime;
        }
    }
}
