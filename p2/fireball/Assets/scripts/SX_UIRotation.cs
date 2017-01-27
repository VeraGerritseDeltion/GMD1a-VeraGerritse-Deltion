using UnityEngine;
using System.Collections;

public class SX_UIRotation : MonoBehaviour {

    private Transform player;

    void Start()
    {
        player = GameObject.Find("Player").transform;
    }

    void Update ()
    {
        transform.LookAt(player.position);
    }
}
