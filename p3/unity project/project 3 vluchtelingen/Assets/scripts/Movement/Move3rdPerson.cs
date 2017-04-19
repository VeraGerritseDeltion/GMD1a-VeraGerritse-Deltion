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
    public Transform mid;
    public float turnSpeed;
    public bool isWalking;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        
    }
    public void movement()
    {
        mid.transform.position = myTransform.position;
        chara = transform.position;
        horizontal = Input.GetAxis("Mouse X") * mouseSen;
        vertical = Input.GetAxis("Mouse Y") * mouseSen;
        movVert = Input.GetAxis("Vertical") * movSpeed;
        movHor = Input.GetAxis("Horizontal") * movSpeed;
        scroll = Input.GetAxis("Mouse ScrollWheel");


        //Cam movement:
        mid.transform.Rotate(0, horizontal * Time.deltaTime, 0);

        cam.transform.Rotate(-vertical * Time.deltaTime, 0, 0);

        //Playerbody:
        transform.Translate(new Vector3(movHor, 0, movVert) * Time.deltaTime);

        if (movHor != 0 || movVert != 0)
        {
            myTransform.rotation = Quaternion.RotateTowards(myTransform.rotation, mid.transform.rotation, turnSpeed * Time.deltaTime);
            myTransform.Rotate(0, horizontal * Time.deltaTime, 0);
            isWalking = true;
           
        }
        else
        {
            isWalking = false;
        }

        if (scroll > 0.0f)
        {
            cam.transform.position = Vector3.MoveTowards(cam.transform.position, chara, scrollSpeed * Time.deltaTime);
        }

        if (scroll < 0.0f)
        {
            cam.transform.position = Vector3.MoveTowards(cam.transform.position, camPoint.transform.position, scrollSpeed * Time.deltaTime);
        }
    }
}
 