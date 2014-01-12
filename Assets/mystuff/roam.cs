using UnityEngine;
using System.Collections;

public class roam : MonoBehaviour {
	
	public float speed = 2f;
	
    void Update() {
        transform.RotateAround(Vector3.zero, Vector3.up, speed * Time.deltaTime);
    }
}