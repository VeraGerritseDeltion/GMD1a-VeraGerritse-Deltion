using UnityEngine;
using System.Collections;

public class Wall : MonoBehaviour {

    public Vector3 open;
    public Vector3 closed;

	void Update () {
        //deur open
        if(Bal.door == false)
      
        {
            transform.position = open;
        }
        // deur dicht
        if (Bal.door == true)
     
        {
            transform.position = closed;
        }
	
	}
}
