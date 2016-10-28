using UnityEngine;
using System.Collections;

public class Flipper : MonoBehaviour {
    public bool acfl;
    public float timer = 0;
    public GameObject flipperl;

	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.B))
        {
            acfl = true;
        }
        if(timer > 0.05f)
        { acfl = false;
        }

        if (acfl == true)
        {
            transform.RotateAround
                (transform.position, flipperl.transform.up, -800 * Time.deltaTime);
            timer = timer + Time.deltaTime;
        }
	}
}
