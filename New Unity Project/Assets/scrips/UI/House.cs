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
    {
        start.enabled = true;
        start = GetComponent<Canvas>();

    }
  
    public void OnButtonClick()
    {
        anim.Play("colorraven");
        
        start.enabled = false;
        start = GetComponent<Canvas>();
        balstart = true;

    }

    public void slyt()
    {
        anim.Play("colorhouse");
        start.enabled = false;
        start = GetComponent<Canvas>();
        balstart = true;
    }

    public void gryf()
    {
        anim.Play("colorgrif");
        start.enabled = false;
        start = GetComponent<Canvas>();
        balstart = true;
    }
   public void huf()
    {
        anim.Play("colorhuf");
        start.enabled = false;
        start = GetComponent<Canvas>();
        balstart = true;
    }

}
