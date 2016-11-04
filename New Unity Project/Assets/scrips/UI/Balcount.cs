using UnityEngine;
using System.Collections;

public class Balcount : MonoBehaviour {
    public Animator bal2;
    public Animator bal3;
   
	void Update () {
        if (Bal.bal2 == true)
        { }
        else if (Bal.bal3 == true)
        {
            bal2.Play("bal2");
        }
        else
        {
            bal2.Play("bal2gone");
        }
        if (Bal.bal3 == true)
        {
            bal3.Play("bal3");
        }
        else
        {
            bal3.Play("bal3gone");
        }
	}
}
