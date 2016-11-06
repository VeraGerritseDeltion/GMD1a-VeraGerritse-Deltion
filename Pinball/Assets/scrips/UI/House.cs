using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class House : MonoBehaviour {
    public Animator anim;
    public Button sly;
    public Button gry;
    public Button huff;
    public Button rav;
    public Canvas start;
    public static bool balstart;
  
    
	void Start()
    {//zorgt dat bij launch canvas aanstaat
        start.enabled = true;
        start = GetComponent<Canvas>();

    }
  void Update()
    {//zodra game herstart canvas aanzetten
        if (GameOver.newballs == true)
        {
            start.enabled = true;
            start = GetComponent<Canvas>();
        }
    }
    public void OnButtonClick()
    {// achtergrond kleur canvas uitzetten en bal plaatsen
        anim.Play("colorraven");
        
        start.enabled = false;
        start = GetComponent<Canvas>();
        balstart = true;

    }

    public void slyt()
    {// achtergrond kleur canvas uitzetten en bal plaatsen
        anim.Play("colorhouse");
        start.enabled = false;
        start = GetComponent<Canvas>();
        balstart = true;
    }

    public void gryf()
    {// achtergrond kleur canvas uitzetten en bal plaatsen
        anim.Play("colorgrif");
        start.enabled = false;
        start = GetComponent<Canvas>();
        balstart = true;
    }
   public void huf()
    {// achtergrond kleur canvas uitzetten en bal plaatsen
        anim.Play("colorhuf");
        start.enabled = false;
        start = GetComponent<Canvas>();
        balstart = true;
    }

}
