using UnityEngine;
using System.Collections;

public class House : MonoBehaviour {
    public Animator anim;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetKey(KeyCode.Y))
        {
            anim.Play("colorraven");
        }
	}
}
