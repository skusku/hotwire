﻿using UnityEngine;
using System.Collections;

public class LoseGame : MonoBehaviour {

    public GameController gameController;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.collider.tag == "Obstacle")
        {
            gameController.RestartGame();
        }
        else if(col.collider.tag == "Goal")
        {
            gameController.WinGame();
        }
    }
}