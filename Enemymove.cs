using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public float EnemymoveX;
	// Use this for initialization
	void Start () {
		


	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(EnemymoveX, 0.0f, 0.0f);
       // EnemyMove();
	}


    //void EnemyMove()
    //{
    //    transform.Translate(EnemymoveX, 0.0f, 0.0f);
    //}
}
