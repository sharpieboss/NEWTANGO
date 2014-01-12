using UnityEngine;
using System.Collections;
 
public class hit_detection : MonoBehaviour {
 
    //public GameObject self;
    //public GameObject targetTag;
	
	public Rigidbody sparks;
 
    // Use this for initialization
    void Start () {
		
    }
 
    // Update is called once per frame
    void Update () {

    }

    void OnTriggerEnter(Collider other) {
		
		if(other.gameObject.tag == "floor"){
			//Rigidbody effect1 = (GameObject)Instantiate(sparks, transform.position, transform.rotation);
			Rigidbody effect1 = Instantiate(sparks, transform.position, transform.rotation) as Rigidbody;
			Destroy (gameObject);
			//kill self
       }
       else if (other.gameObject.tag == "enemy"){
			//kill enemy and self
			Destroy(other.gameObject);
			Destroy (gameObject);
       }
		
	}
}