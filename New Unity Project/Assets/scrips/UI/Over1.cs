using UnityEngine;
using System.Collections;

public class Over1 : MonoBehaviour {
    public Vector3 over;
    public Vector3 back;

	
	void Start()
    {
        back.x = -8.27f;
        back.y = 4.58f;
        back.z = 3.43f;
    }
	// Update is called once per frame
	void Update () {
        if (GameObject.Find("bal1").GetComponent<Bal>().over1 == true)
        {
            transform.position = over;
        }
        if (Bal.bal2 == true) { }
        else if (Bal.bal3 == true)

        {
            transform.position = back;
        }

    }
}
