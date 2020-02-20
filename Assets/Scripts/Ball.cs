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
			Rb.AddForce(new Vector2(-MoveForce, 0f));
		}
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if(collision.gameObject.CompareTag("Wall"))
		{
			GetComponent<SpriteRenderer>().color = Color.red;
		}
		else if(collision.gameObject.CompareTag("Goal"))
		{
			SceneManager.LoadScene(TargetSceneIndex);
		}
	}
}
