using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DandFScript : MonoBehaviour
{
    public GameObject destroyObj;
    
    
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag( "Player"))
        {
            Instantiate(destroyObj, transform.position, transform.rotation);
            Destroy(gameObject);
          

           
        }
       
        
    }
    















}
