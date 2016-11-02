using UnityEngine;
using System.Collections;

public class Over2 : MonoBehaviour {
    public Vector3 over;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
      if  (GameObject.Find("bal1").GetComponent<Bal>().over2 == true)
        {
            transform.position = over;
        }

    }
}
