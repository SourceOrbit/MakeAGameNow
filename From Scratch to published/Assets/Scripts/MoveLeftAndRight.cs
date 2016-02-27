using UnityEngine;
using System.Collections;

public class MoveLeftAndRight : MonoBehaviour {

	public float speed = 1.0f;

	void Start () 
	{
	
	}
	
	void Update () 
	{
		transform.position += Vector3.right * Input.GetAxis("Horizontal") * speed * Time.deltaTime;	}
 	}
