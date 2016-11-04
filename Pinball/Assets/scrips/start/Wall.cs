using UnityEngine;
using System.Collections;

public class Wall : MonoBehaviour {

    public Vector3 open;
    public Vector3 closed;

	void Update () {
        // if(Bal.door == false)
        if (Input.GetKey(KeyCode.K))
        {
            transform.position = open;
        }
       // if (Bal.door == true)
       if (Input.GetKey(KeyCode.L))
        {
            transform.position = closed;
        }
	
	}
}
