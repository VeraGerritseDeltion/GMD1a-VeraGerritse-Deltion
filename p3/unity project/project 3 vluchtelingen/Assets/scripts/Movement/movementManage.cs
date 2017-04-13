using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementManage : MonoBehaviour {
    public Move3rdPerson normalMovement;
    public ConversationManager conversations;
    public bool standingStill;


	void Start () {
		
	}


    void Update() {
        if (conversations.isTalking == false)
        {
            standingStill = false;
        }
        else
        {
            standingStill = true;
        }

        if(standingStill == false)
        {
            normalMovement.movement();
        }
	}
}
