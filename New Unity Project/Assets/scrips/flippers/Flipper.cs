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
    {
        down.x = 44;
        up.x = 41f;
        up.y = -29.167f;
        up.z = -12.841f;
    }
    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetButton("Fire1"))
        {
            acfl = true;
            timer2 = 0;
        }
        if (timer > 0.1f)
        {
            acfl = false;
          transform.localEulerAngles = up;

        }

        if (acfl == true)
        {
            transform.RotateAround
                (transform.position, flipperl.transform.right, -200 * Time.deltaTime);
            timer = timer + Time.deltaTime;

        }

        if (Input.GetButtonUp("Fire1"))
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
                (transform.position, flipperl.transform.right, 200 * Time.deltaTime);
            timer2 = timer2 + Time.deltaTime;
        }

    }
 
}
