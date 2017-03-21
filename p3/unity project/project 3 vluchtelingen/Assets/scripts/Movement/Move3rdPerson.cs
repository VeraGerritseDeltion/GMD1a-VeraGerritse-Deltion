using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move3rdPerson : MonoBehaviour {
    public Transform myTransform;
    public GameObject camPoint;
    public Camera cam;
    public float movSpeed;
    public float mouseSen;
    public float horizontal;
    public float vertical;
    public float movVert;
    public float movHor;
    public float scroll;
    public float scrollSpeed;
    public Vector3 chara;
    public Vector3 cammera;

	// Use this for initialization
	void Start () {
        chara = transform.position;
        cammera = cam.transform.position;
	}
	
	// Update is called once per frame
	void Update () {

        horizontal = Input.GetAxis("Mouse X") * mouseSen ;
        vertical = Input.GetAxis("Mouse Y") * mouseSen ;
        movVert = Input.GetAxis("Vertical") * movSpeed;
        movHor = Input.GetAxis("Horizontal") * movSpeed;
        scroll = Input.GetAxis("Mouse ScrollWheel");

        myTransform.Rotate (0,horizontal * Time.deltaTime,0);
        transform.Translate(new Vector3 (movHor,0, movVert) * Time.deltaTime);
        cam.transform.Rotate(-vertical* Time.deltaTime, 0, 0);

        //cam.transform.Translate((transform.position - cam.transform.position).normalized * scrollSpeed * Time.deltaTime * scroll);

    if(scroll > 0.0f)
        {
            cam.transform.position = Vector3.MoveTowards(cam.transform.position, chara, scrollSpeed * Time.deltaTime);
        }
    if (scroll < 0.0f)
        {
            cam.transform.position = Vector3.MoveTowards(cam.transform.position, camPoint.transform.position, scrollSpeed *Time.deltaTime);
        }





    }
}
 