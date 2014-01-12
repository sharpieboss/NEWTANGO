using UnityEngine;
using System.Collections;

public class tidy : MonoBehaviour {
	
	
	public float timer = 5f;
	
	// Use this for initialization
	void Start () {
		Destroy(gameObject, timer);
	}

}
