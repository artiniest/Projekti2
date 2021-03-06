﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour 
{
	public float bullSpeed = 10f;

	void Update () 
	{

		if (gameObject.tag == "Bullet") 
		{
			transform.Translate (new Vector2 (bullSpeed * Time.deltaTime, 0));

			if (transform.position.x > 25) 
			{
				Destroy (gameObject);
			}
		}

		if (gameObject.tag == "EnemyBullet") 
		{
			transform.Translate (new Vector2 (-bullSpeed/2 * Time.deltaTime, 0));

			if (transform.position.x < -20.5) 
			{
				Destroy (gameObject);
			}
		}

		if (gameObject.tag == "Bubble") 
		{
			transform.Translate (Vector3.right * (-bullSpeed) * Time.deltaTime);
		}
	}
}
