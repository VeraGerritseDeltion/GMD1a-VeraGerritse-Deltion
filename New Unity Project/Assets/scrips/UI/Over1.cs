using UnityEngine;
using System.Collections;

public class Over1 : MonoBehaviour {
    public Vector3 over;


	
	
	// Update is called once per frame
	void Update () {
        if (GameObject.Find("bal1").GetComponent<Bal>().over1 == true)
        {
            transform.position = over;
        }


    }
}
