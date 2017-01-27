using UnityEngine;
using System.Collections;

public class SX_SpawnPoint : MonoBehaviour {
    public Vector3 spawn;
    public Vector3 spawnRotation;

	void Update () {
        spawn = transform.position;
        spawnRotation = transform.eulerAngles;
	}
}
