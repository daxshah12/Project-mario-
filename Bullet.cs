using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	private float Timer;

	void Update()
	{
		Timer += 1.0f * Time.deltaTime;
		if (Timer >= 2.0f)
		{
			GameObject.Destroy(gameObject);
		}
	}
	private void OnCollisionEnter2D(Collision2D col)
	{
		Debug.Log("Collider with enemy");
		if (col.gameObject.tag == "Enemy")
		{
			Destroy(col.gameObject);
			Destroy(gameObject);
		}

	}
}
