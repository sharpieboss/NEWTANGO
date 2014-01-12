using UnityEngine;
using System.Collections;
 
public class tank_got_hit : MonoBehaviour {

	
	//public Rigidbody cubes;
	public ParticleSystem sparks;
	public ParticleSystem explode;
	public int health = 5;
	public float speed = 2f;
	private bool dead = false;
	public AudioClip deathsound;
 
    // Use this for initialization
    void Start () {
		
    }
 
    // Update is called once per frame
    void Update () {
		
		if (health <= 0 && !dead )
		{
			//explode
			ParticleSystem effect2 = Instantiate(explode, transform.position , transform.rotation) as ParticleSystem;
			
			dead = true;
			
			audio.PlayOneShot(deathsound);
			//Destroy(gameObject);
		}
		if( !dead )
		{
			transform.RotateAround(Vector3.zero, Vector3.up, speed * Time.deltaTime);
		}

    }

    void OnTriggerEnter(Collider other) {
		
		if(other.gameObject.tag == "bullet"){
			//Rigidbody make_a_cube = Instantiate(cubes, other.transform.position , other.transform.rotation) as Rigidbody;
			ParticleSystem effect1 = Instantiate(sparks, other.transform.position , other.transform.rotation) as ParticleSystem;
			Destroy (other.gameObject);
			health = health - 1;
			
		}
		
	}
}