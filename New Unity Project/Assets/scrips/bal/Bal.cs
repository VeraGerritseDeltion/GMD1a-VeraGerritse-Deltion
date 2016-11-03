using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Bal : MonoBehaviour
{
    public Vector3 teleport;
    public bool utr;
    public bool dtr;
    public bool dtl;
    public bool utl;
    public Vector3 dir;
    public float handen;
    public float tijd;
    public static int score = 0;
    public static int highscore = 0;
    public Text score1;
    public Text hscore1;
    public bool test;
    public bool nieuwebal;
    public Vector3 nieuw;
    public bool test1;
    public int balls = 3;
    public Vector3 minbal;
    public bool over2;
    public bool over1;
    public bool gameover1;
    public static bool bal2;
    public static bool bal3;
    public int testscore = 0;



    void Start()
    {
        nieuw.x = -7.58f;
        nieuw.y = 0.57f;
        nieuw.z = 3.19f;
        
    }


    void Update()
    {
        { {
                score1.text = score.ToString();

                if (GameOver.newballs == true)
            {
                balls = 3;
                    score = 0;
            }

            if (Input.GetKey(KeyCode.P))
                {
                    balls = 0;
                }

            if (balls == 3)
                {
                    bal3 = true;
                }
                else
                {
                    bal3 = false;
                }

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

            if (balls  == 1)
                {
                    over1 = true;
                }
            else
                {
                    over1 = false;
                }

            if (balls == 0)
                {
                    gameover1 = true;
                }
            else
                {
                    gameover1 = false;
                }

            if (utr == true)


            {
                transform.position = teleport;
            }
            if (utl == true)


            {
                transform.position = teleport;
            }
            if (dtl == true)


            {
              
                transform.position = teleport;
            }


            if (dtr == true)


            {
                transform.position = teleport;
            }
          utr = false;
            dtr = false;
            dtl = false;
            utl = false;


        }
        if (tijd > 0.5f)
        {
           
            handen = 0;
            tijd = 0;
        }
    } 
        //test reset score
        if (test == true)
        {
            score = 0;
        }

      
        if (score >= highscore)
        {
            highscore = score;
        }
        hscore1.text = highscore.ToString();

        if (House.balstart == true)
        {
            transform.position = nieuw;
            House.balstart = false;
        }
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "tld")
        {
            teleport.x = -5.11f;
            teleport.y = 6.18f;
            teleport.z = -7.39f;
            dtl = true;
            test1 = true;
        }
        if (collision.collider.tag == "tlu")
        {
            teleport.x = -5.11f;
            teleport.y = 6.18f;
            teleport.z = -7.39f;
            utl = true;
          
        }
        if (collision.collider.tag == "trd")
        {
            teleport.x = 4.9f;
            teleport.y = 6.13f;
            teleport.z = -9;
            dtr = true;
           
        }
        if (collision.collider.tag == "tru")
        {
            teleport.x = 4.9f;
            teleport.y = 6.13f;
            teleport.z = -9;
            utr = true;
            test1 = true;
        }
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

    public void tim()
    {
        handen = handen + 1;
        tijd = Time.deltaTime * handen;
    }
    
}
