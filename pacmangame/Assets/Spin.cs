using UnityEngine;
using System.Collections;

public class Spin : MonoBehaviour {
	
	public float speed = 20f;
	
	void Update () {
		transform.Rotate(Vector3.back, speed * Time.deltaTime);
		transform.Rotate(Vector3.up, speed * Time.deltaTime);
		transform.Rotate(Vector3.left, speed * Time.deltaTime);
	}
}
