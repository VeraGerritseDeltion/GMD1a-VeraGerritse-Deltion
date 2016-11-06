using UnityEngine;
using System.Collections;

public class Flipper : MonoBehaviour {
    public static bool acfl;
    public bool back;
    public float timer = 0;
    public float timer2 = 0;
    public GameObject flipperl;
    public Vector3 up;
    public Vector3 down;
    public Vector3 dir;
    public Rigidbody bal;

    void Start()
    {// rotatie coords
        down.x = 44;
        up.x = 41f;
        up.y = -29.167f;
        up.z = -12.841f;
    }

    void Update()
    {
       // als je linker muis in klikt schiet af en reset timer
        if (Input.GetButton("Fire1"))
        {
            acfl = true;
            timer2 = 0;
        }
        // hoelang de rotatie duurt en correctie
        if (timer > 0.1f)
        {
            acfl = false;
          transform.localEulerAngles = up;

        }
        // draait de flipper en start timer
        if (acfl == true)
        {
            transform.RotateAround
                (transform.position, flipperl.transform.right, -200 * Time.deltaTime);
            timer = timer + Time.deltaTime;

        }
        //als je los laat gaat hij weer naar beneden
        if (Input.GetButtonUp("Fire1"))
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
                (transform.position, flipperl.transform.right, 200 * Time.deltaTime);
            timer2 = timer2 + Time.deltaTime;
        }

    }
 
}
