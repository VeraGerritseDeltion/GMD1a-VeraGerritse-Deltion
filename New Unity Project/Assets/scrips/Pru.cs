using UnityEngine;
using System.Collections;

public class Pru : MonoBehaviour {
    public bool test2;

    public ParticleSystem ps;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (test2 == true)
        {
            ps = GetComponent<ParticleSystem>();
            var em = ps.emission;
            em.enabled = true;
        }
        else
        {
            ParticleSystem ps = GetComponent<ParticleSystem>();
            var em = ps.emission;
            em.enabled = false;
        }

    }

}
