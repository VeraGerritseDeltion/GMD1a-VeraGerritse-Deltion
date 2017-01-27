using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
    public float movSpeed = 7;
    public float mouseSens = 5;
    public float upDownrange = 20;
    float vertRot = 0;
    public float rotLefttoRight;
    public Vector3 spawnRotation;

    void Update()
    {
        if (SX_GameManager.playing == true)
        {
            rotLefttoRight = Input.GetAxis("Mouse X") * mouseSens;
            transform.Rotate(0, rotLefttoRight, 0);
            spawnRotation = transform.localEulerAngles;

            float rotupdown = Input.GetAxis("Mouse Y") * mouseSens;
            vertRot -= rotupdown;
            vertRot = Mathf.Clamp(vertRot, -upDownrange, upDownrange);
            Camera.main.transform.localRotation = Quaternion.Euler(vertRot, 0, 0);

            float forwardSpeed = Input.GetAxis("Vertical") * movSpeed;
            float sideSpeed = Input.GetAxis("Horizontal") * movSpeed;

            Vector3 speed = new Vector3(sideSpeed, 0, forwardSpeed);

            speed = transform.rotation * speed;
            CharacterController cc = GetComponent<CharacterController>();

            cc.SimpleMove(speed);
        }
    }
}
