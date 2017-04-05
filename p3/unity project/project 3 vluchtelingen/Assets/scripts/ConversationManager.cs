using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversationManager : MonoBehaviour {

    public int plusCount;
    public string vraag;
    public string antwoord1;
    public string antwoord2;
    public int antwoordNummer;
    public string iets= "antwoord";
    public RaycastHit targetHit;
    public int rayCastLenght;
    public GameObject camRotation;
    public Conversation cons;

    void Update () {
        if (Physics.Raycast(transform.position,camRotation.transform.forward, out targetHit, rayCastLenght))
        {
            if (targetHit.collider.tag == "npc" && Input.GetButtonDown("Talk"))
            {
             cons = targetHit.collider.GetComponent<Conversation>();
            }
        }

        
        Debug.DrawRay(transform.position, transform.forward * rayCastLenght);

          if (cons != null) {
            if (antwoordNummer < cons.questions.Count  )
            {
                vraag = cons.questions[antwoordNummer];
                antwoord1 = cons.awnsers[antwoordNummer * 2];
                antwoord2 = cons.awnsers[antwoordNummer * 2 + 1];
            }

            if (antwoordNummer >= cons.questions.Count)
            { 
                cons = null;
                antwoordNummer = 0;
            }
        }
	}

    public void Awnser(int a)
    {
        if (cons != null)
        {

            if (antwoordNummer * 2 + 1 < cons.awnsers.Count && antwoordNummer < cons.questions.Count)
            {
                if (a == 1)
                {
                    plusCount = 1;
                }
                if (a == -1)
                {
                    plusCount = 2;
                }

                antwoordNummer = antwoordNummer * 2 + plusCount;

            }
        }
    }
}
