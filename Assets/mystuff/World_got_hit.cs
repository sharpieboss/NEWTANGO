using UnityEngine;
using System.Collections;
 
public class World_got_hit : MonoBehaviour {

	
	//public Rigidbody cubes;
	public ParticleSystem sparks;
 
    // Use this for initialization
    void Start () {
		
    }
 
    // Update is called once per frame
    void Update () {

    }

    void OnTriggerEnter(Collider other) {
		
		if(other.gameObject.tag == "bullet"){
			//Rigidbody make_a_cube = Instantiate(cubes, other.transform.position , other.transform.rotation) as Rigidbody;
			ParticleSystem effect1 = Instantiate(sparks, other.transform.position , other.transform.rotation) as ParticleSystem;
			Destroy (other.gameObject);
			//kill self
			
		}
		
	}
}