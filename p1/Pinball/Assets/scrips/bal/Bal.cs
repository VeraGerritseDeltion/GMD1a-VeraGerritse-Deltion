using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Bal : MonoBehaviour
{
    public Vector3 teleport;
    public static bool utr;
    public static bool dtr;
    public static bool dtl;
    public static bool utl;
    public static int score = 0;
    public static int highscore = 0;
    public Text score1;
    public Text hscore1;
    public bool nieuwebal;
    public Vector3 nieuw;
    public static bool part1;
    public static bool part2;
    public static bool part3;
    public static bool part4;
    public int balls = 3;
    public Vector3 minbal;
    public bool over2;
    public bool over1;
    public bool gameover1;
    public static bool bal0;
    public static bool bal1;
    public static bool bal2;
    public static bool bal3;
    public static bool door;



    void Start()
    {// start locatie
        nieuw.x = -7.58f;
        nieuw.y = 0.57f;
        nieuw.z = 3.19f;
        
    }


    void Update()
    {
        { {// score bij houden
                score1.text = score.ToString();

                //reset ballen en score

                if (GameOver.newballs == true)
                {
                    balls = 3;
                    score = 0;
                }
            // als er nog 3 ballen zijn
            if (balls == 3)
                {
                    bal3 = true;
                }
                else
                {
                    bal3 = false;
                }

            // als er nog 2 ballen zijn
            if (balls == 2)
                {
                    over2 = true;
                    bal2 = true;
                }
            else
                {
                    over2 = false;
                    bal2 = false;
                }

            //als er nog 1 bal is
            if (balls  == 1)
                {
                    over1 = true;
                    bal1 = true;
                }
            else
                {
                    over1 = false;
                    bal1 = false;
                }

            //als je geen ballen hebt
            if (balls == 0)
                {
                    gameover1 = true;
                    transform.position = minbal;
                    bal0 = true;
                }
            else
                {
                    gameover1 = false;
                    bal0 = false;
                }
            // teleport
            if (utr == true)
            {
                transform.position = teleport;
            }

                // teleport
                if (utl == true)
            {
                transform.position = teleport;
            }

                // teleport
                if (dtl == true)
            {
              
                transform.position = teleport;
            }

                // teleport
                if (dtr == true)
            {
                transform.position = teleport;
            }

                //reset teleports
          utr = false;
            dtr = false;
            dtl = false;
            utl = false;


        }
        
    } 
       
      //set highscore
        if (score >= highscore)
        {
            highscore = score;
        }

        hscore1.text = highscore.ToString();

        //bal start locatie
        if (House.balstart == true)
        {
            transform.position = nieuw;
            House.balstart = false;
        }
    }
    public void OnCollisionEnter(Collision collision)
    {// teleport
        if (collision.collider.tag == "tld")
        {
            teleport.x = -5.11f;
            teleport.y = 6.18f;
            teleport.z = -7.39f;
            dtl = true;
            part1 = true;
        }
        // teleport
        if (collision.collider.tag == "tlu")
        {
            teleport.x = -5.11f;
            teleport.y = 6.18f;
            teleport.z = -7.39f;
            utl = true;
            part2 = true;

        }
        // teleport
        if (collision.collider.tag == "trd")
        {
            teleport.x = 4.9f;
            teleport.y = 6.13f;
            teleport.z = -9;
            dtr = true;
            part3 = true;

        }
        // teleport
        if (collision.collider.tag == "tru")
        {
            teleport.x = 4.9f;
            teleport.y = 6.13f;
            teleport.z = -9;
            utr = true;
            part4 = true;
        }
       //nieuwe bal
        if (collision.collider.tag == "des")
        {
            transform.position = nieuw;
            balls = balls - 1;
        }
        //score
        if (collision.collider.tag == "bumpers")
        {
            score = score + 10;
           
                 
        }
       
        
    }
    
    // deur dicht
    void OnTriggerEnter(Collider trigger)
    {
        door = true;
    
    }
    
}
