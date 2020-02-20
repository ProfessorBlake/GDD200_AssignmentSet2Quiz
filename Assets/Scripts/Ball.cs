using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
	public int TargetSceneIndex;
	public Rigidbody2D Rb;
	public float MoveForce = 2f;

	private void FixedUpdate()
	{
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			
		}
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		
	}
}
