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

    // Use this for initialization
    void Start()
    {
        up.x = 21.128f;
        up.y = 24.818f;
        up.z = 9.732f;
        down.x = 23.188f;
        

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetButton("Fire2"))
        {
            flip = true;
            timer2 = 0;
        }
        if (timer > 0.1f)
        {
            flip = false;
            transform.localEulerAngles = up;


        }

        if (flip == true)
        {
            transform.RotateAround
                (transform.position, flipperl.transform.right, 200 * Time.deltaTime);
            timer = timer + Time.deltaTime;

        }

        if (Input.GetButtonUp("Fire2"))
        {
            back = true;
            timer = 0;
        }
        if (timer2 > 0.1f)
        {
            back = false;
            transform.localEulerAngles = down;

        }

        if (back == true)
        {
            transform.RotateAround
                (transform.position, flipperl.transform.right, -200 * Time.deltaTime);
            timer2 = timer2 + Time.deltaTime;
        }
    }
}
