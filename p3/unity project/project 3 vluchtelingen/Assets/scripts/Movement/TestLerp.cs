using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestLerp : MonoBehaviour {
    public Transform start;
    public Transform eind;
    public float speed;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        transform.rotation = Quaternion.Lerp(start.rotation, eind.rotation, speed *Time.time );
		
	}
}
