using UnityEngine;
using System.Collections;

public class Tijds : MonoBehaviour {
    public float handen;
    public float tijd;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        handen = handen + 1;
        tijd = Time.deltaTime * handen;


    }
}
