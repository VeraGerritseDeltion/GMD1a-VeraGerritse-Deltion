using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SX_SpawnEnemy : MonoBehaviour {
    public GameObject targetDummy;
    public int amountDummy;
    public List<GameObject> dummys = new List<GameObject>();
    public GameObject dummy;


	void Start ()
    {
        SpawnEnemyFirst();
	}
	
	void Update ()
    {
        amountDummy = SX_GameManager.enemyLevel;
	}

    public void SpawnEnemyFirst()
    {
        Vector3 loc = new Vector3(0, -1.34f, 30);
        dummys.Add (dummy = Instantiate(targetDummy, loc, Quaternion.identity) as GameObject);
        dummy.GetComponent<SX_Enemy>().quest = gameObject.GetComponent<SX_Quest>();
    }

    public void SpawnEnemy()
    {
        for(int i = 0;i < amountDummy; i++)
        {
            Vector3 loc = new Vector3(Random.Range(-40, 32), -1.34f, Random.Range(-0.5f, 49));
            dummys.Add(dummy =  Instantiate(targetDummy,loc,Quaternion.identity ) as GameObject);
            dummy.GetComponent<SX_Enemy>().quest = gameObject.GetComponent<SX_Quest>();
        }
    }

    public void Resetting()
    {   amountDummy = SX_GameManager.enemyLevel;
        for (int o = 0; o < dummys.Count; o++)
        {            
                Destroy(dummys[o]);
            
        }
        dummys.Clear();
        SpawnEnemy();
    }
}
