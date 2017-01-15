using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    public Paddle paddle;
    private bool hasStarted = false;
    private Vector3 paddleToBallVector;
    private Rigidbody2D ballRigidBody2D;
	// Use this for initialization
	void Start () {
        paddleToBallVector = this.transform.position - paddle.transform.position;
        ballRigidBody2D = GetComponent<Rigidbody2D>();
        print(paddleToBallVector);
	}
	
	// Update is called once per frame
	void Update () {
        if (!hasStarted){ // Checking if the game is started if not, we keep the ball down
            this.transform.position = paddle.transform.position + paddleToBallVector;
            if (Input.GetMouseButtonDown(0)){ //if we click on the left click, we launch the ball
                hasStarted = true;
                this.ballRigidBody2D.velocity = new Vector2(2f, 10f);
            }
        }
	}
}
