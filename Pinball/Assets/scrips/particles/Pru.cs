using UnityEngine;
using System.Collections;

public class Pru : MonoBehaviour {
    public bool ro;
    public bool lo;
    public bool lb;
    public bool rb;
    public bool test;
    public ParticleSystem lop;
    public ParticleSystem rop;
    public ParticleSystem lbp;
    public ParticleSystem rbp;
    

   
    void Update()
    {
        if (GameObject.Find("bal1").GetComponent<Bal>().dtl == true)
        {
            
            lo = true;
        }
        if (test == true)
        {
            lo = true;
        }
      
        // links onder
        if (lo == true)
        {
            lop = GetComponent<ParticleSystem>();
            var em = lop.emission;
            em.enabled = true;

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
            var om = rop.emission;
            om.enabled = true;
        }
        else
        {
            rop = GetComponent<ParticleSystem>();
            var om = rop.emission;
            om.enabled = false;
        }
        //links boven
        if (lb == true)
        {
            lbp = GetComponent<ParticleSystem>();
            var pm = lbp.emission;
            pm.enabled = true;
        }
        else
        {
            lbp = GetComponent<ParticleSystem>();
            var pm = lbp.emission;
            pm.enabled = false;
        }
        //rechts boven
        if (rb == true)
        {
            rbp = GetComponent<ParticleSystem>();
            var lm = rbp.emission;
            lm.enabled = true;
        }
        else
        {
            rbp = GetComponent<ParticleSystem>();
            var lm = rbp.emission;
            lm.enabled = false;
        }
    }
}
