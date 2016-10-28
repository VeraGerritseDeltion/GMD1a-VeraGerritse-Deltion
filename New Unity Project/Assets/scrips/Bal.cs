using UnityEngine;
using System.Collections;

public class Bal : MonoBehaviour
{
    public Vector3 teleport;
    public bool utr;
    public bool dtr;
    public bool dtl;
    public bool utl;
    public Vector3 dir;
    public ParticleSystem part;
    public ParticleSystem p2;
    public bool parti;
    public bool part2;
    public float handen;
    public float tijd;

    void Update()
    {
        {
            if (parti == true)
            {
                part.Play();
                tim();
            }
            else
            {
                part.Stop();

            }
            {
                if (part2 == true)
                {
                    p2.Play();
                }
                else
                {
                    p2.Clear();
                    p2.Pause();

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
                    parti = true;
                    part2 = true;

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
                parti = false;
                handen = 0;
                tijd = 0;
            }
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

        }
        if (collision.collider.tag == "des")
        {
            Destroy(gameObject);
        }

    }

    public void tim()
    {
        handen = handen + 1;
        tijd = Time.deltaTime * handen;
    }
}
