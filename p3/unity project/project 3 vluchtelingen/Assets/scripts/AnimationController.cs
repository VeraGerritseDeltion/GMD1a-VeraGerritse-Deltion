using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour {
    public Animator player;
    public int headShake;
    public int chance;
    public Move3rdPerson moving;
	void Start () {
		
	}
	

	void Update () {
        headShake = Random.Range(0, chance);
        if (headShake == chance - 1)
        {
            player.SetBool("headShake", true);
            print("joi");
        }
        else
        {
            player.SetBool("headShake", false);
        }
        if (moving.isWalking == true)
        {
            player.SetBool("isWalking", true); 
        }
        else
        {
            player.SetBool("isWalking", false);
        }
		
	}
}
