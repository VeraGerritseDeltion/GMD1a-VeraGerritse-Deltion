using UnityEngine;
using System.Collections;

public class Balcount : MonoBehaviour {
    public Animator bal0;
    public Animator bal1;
    public Animator bal2;
    public Animator bal3;
   
	void Update () {
        // als je geen ballen meer hebt
        if (Bal.bal0 == true)
        {
            bal0.Play("smoke");
        }
        else
        {
            bal0.Play("smokeoff");
        }
        // als je 2 of meer ballen hebt
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
        //als je 3 ballen hebt
        if (Bal.bal3 == true)
        {
            bal3.Play("bal3");
        }
        else
        {
            bal3.Play("bal3gone");
        }
        //als je 1 of meer ballen hebt
        if (Bal.bal1) { }
        else if (Bal.bal2) { }
        else if (Bal.bal3)
        {
            bal1.Play("there");
        }
        else
        {
            bal1.Play("weg");
        }
	}
}
