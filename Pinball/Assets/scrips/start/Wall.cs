using UnityEngine;
using System.Collections;

public class Wall : MonoBehaviour {

    public Vector3 open;
    public Vector3 closed;

	void Update () {
        if(Bal.door == false)
      
        {
            transform.position = open;
        }
        if (Bal.door == true)
     
        {
            transform.position = closed;
        }
	
	}
}
