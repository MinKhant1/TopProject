using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knockBackTest : MonoBehaviour {


    public Rigidbody parRb;
    [SerializeField]
    private float knockforce;
	// Use this for initialization
	void Start () {
        parRb = GameObject.Find("TopParent").GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void OnCollisionEnter(Collision collision)
    {
        
            //Debug.Log("Top hit");
        

    }

    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Top"))
        {

            Vector3 direction = transform.position - other.transform.position;
            Debug.DrawRay(transform.position , other.transform.position,Color.blue);
            parRb.AddForce(direction.normalized * knockforce,ForceMode.Impulse);
            Debug.Log("Top Hit");
        }
    }
    
}
