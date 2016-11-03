using UnityEngine;
using System.Collections;

public class Over2 : MonoBehaviour {
    public Vector3 over;
    public Vector3 back;

	// Use this for initialization
	void Start () {
        back.x = -9.81f;
        back.y = 4.59f;
        back.z = 3.43f;
	
	}
	
	// Update is called once per frame
	void Update () {
      if  (GameObject.Find("bal1").GetComponent<Bal>().over2 == true)
        {
            transform.position = over;
        }
      if (Bal.bal3 == true)
        {
            transform.position = back;
        }

    }
}
