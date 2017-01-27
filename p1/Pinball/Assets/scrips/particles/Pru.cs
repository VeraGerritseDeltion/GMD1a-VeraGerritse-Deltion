using UnityEngine;
using System.Collections;

public class Pru : MonoBehaviour {
 
    public Animator lu;
    public Animator ld;
    public Animator ru;
    public Animator rd;
    public bool lub = false;
    public bool ldb = false;
    public bool rub = false;
    public bool rdb = false;
    public float times;
   

    void Update()
    {//links onder
        if (Bal.part1 == true)
        {
            ldb = true;
            rub = true;
            timer();
           
        }
      
    //links boven
        if (Bal.part2 == true)
        {
            lub = true;
            rub = true;
            timer();
        }
       
    //rechts onder
        if (Bal.part3 == true)
        {
            rdb = true;
            lub = true;
            timer();
        }
    //rechts boven
        if (Bal.part4 == true)
        {
            rub = true;
            lub = true;
            timer();
        }
//links boven particle
        if (lub == true)
        {
            lu.Play("particlelu");
          
        }
        else
        {
            lu.Play("particleluoff");
        }
        // rechts boven particle
        if (rub == true)
        {
            ru.Play("partru");
       
        }
        else
        {
            ru.Play("partruoff");
        }
        //rechts onder particle
        if (rdb == true)
        {
            rd.Play("particlerd");
           
        }
        else
        {
            rd.Play("particlerdoff");
        }
        //links onder particle

        if (ldb == true)
        {
            ld.Play("particleld");
       
        }
        else
        {
            ld.Play("particleldoff");
        }
        //reset na 1 sec
        if (times > 1)
        {
            Bal.part1 = false;
            Bal.part2 = false;
            Bal.part3 = false;
            Bal.part4 = false;
            lub = false;
            ldb = false;
            rub = false;
            rdb = false;
            times = 0;
        }
    }
    //timer
        public void timer()
        {
        
        times = times + Time.deltaTime;
        }
    }

