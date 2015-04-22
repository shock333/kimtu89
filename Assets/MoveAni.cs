using UnityEngine;
using System.Collections;

public class MoveAni : MonoBehaviour {
	
	public CharacterController CC;
	float MoveSpeed;
	protected  Animator animator ;
	float directionX =  0 ;
	float directionY =  0 ;
	bool walking =  false ;
	bool keyPressed = false;
	
	// Use this for initialization
	void Start () {
		animator =  GetComponent < Animator > ();
	}
	
	// Update is called once per frame
	void Update () {
		if (animator) {
			walking =  true ;
			keyPressed = false;
			if (Input.GetKey (KeyCode.W)) {
				directionX = 0;
				directionY = 1;
				keyPressed = true;
			}
			if (Input.GetKey (KeyCode.A)) {
				directionX = - 1;
				directionY = 0;
				keyPressed = true;
			}
			if (Input.GetKey (KeyCode.S)) {
				directionX = 0;
				directionY = - 1;
				keyPressed = true;
			}
			if (Input.GetKey (KeyCode.D)) {
				directionX = 1;
				directionY = 0;
				keyPressed = true;
			}
			if (!keyPressed) {
				walking = false;
			}
			animator .SetFloat ("DirectionX", directionX);
			animator .SetFloat ("DirectionY", directionY);
			animator .SetBool ("Walking", walking);
		}
		
	}
}
