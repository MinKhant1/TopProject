using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpanwnScript : MonoBehaviour
{


    public Transform[] Spawners;
   public GameObject Top;
    
    void Start()
    {
       
        Spawners = new Transform[transform.childCount]; 
        for(int i=0;i<Spawners.Length;i++)
        {
            Spawners[i] = transform.GetChild(i);
        }
        SpawnTop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnTop()
    {
        Instantiate(Top,Spawners[Random.Range(0,Spawners.Length)]);

    }
}
