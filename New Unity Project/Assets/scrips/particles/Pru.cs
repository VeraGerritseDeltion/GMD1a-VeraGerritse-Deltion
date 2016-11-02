using UnityEngine;
using System.Collections;

public class Pru : MonoBehaviour {
    public bool ro;
    public bool lo;
    public bool lb;
    public bool rb;
    public ParticleSystem lop;
    public ParticleSystem rop;
    public ParticleSystem lbp;
    public ParticleSystem rbp;
    

   
    void Update()
    {
        if (GameObject.Find("bal2").GetComponent<Bal>().dtl == true)
        {
            
            lo = true;
        }
      
        // links onder
        if (lo == true)
        {
            lop = GetComponent<ParticleSystem>();
            var em = lop.emission;
            em.enabled = true;
            print(GameObject.Find("bal2").GetComponent<Bal>().dtl == true);
        }
        else
        {
            lop = GetComponent<ParticleSystem>();
            var em = lop.emission;
            em.enabled = false;
        }

        // rechts onder
        if (ro == true)
        {
            rop = GetComponent<ParticleSystem>();
            var em = rop.emission;
            em.enabled = true;
        }
        else
        {
            rop = GetComponent<ParticleSystem>();
            var em = rop.emission;
            em.enabled = false;
        }
        //links boven
        if (lb == true)
        {
            lbp = GetComponent<ParticleSystem>();
            var em = lbp.emission;
            em.enabled = true;
        }
        else
        {
            lbp = GetComponent<ParticleSystem>();
            var em = lbp.emission;
            em.enabled = false;
        }
        //rechts boven
        if (rb == true)
        {
            rbp = GetComponent<ParticleSystem>();
            var em = rbp.emission;
            em.enabled = true;
        }
        else
        {
            rbp = GetComponent<ParticleSystem>();
            var em = rbp.emission;
            em.enabled = false;
        }
    }
}
