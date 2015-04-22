using UnityEngine;
using System.Collections;

public class CharMoving : MonoBehaviour {

	public CharacterController CC;
	float MoveSpeed;
	protected  Animator animator ;
	public GameObject attackObj;
	public GameObject attackPnt;
	public bool LMouseclicked;
	// Use this for initialization
	void Start () {
		MoveSpeed = 2;
		animator =  GetComponent < Animator > ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Instantiate(attackObj,attackPnt.transform.position,attackPnt.transform.rotation);
			LMouseclicked = true;
		}
		else{
			LMouseclicked = false;
		}
		if (Input.GetKey (KeyCode.W)) {
				CC.Move (transform.up * MoveSpeed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.A)) {
				CC.Move (transform.right * -1f * MoveSpeed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.S)) {
				CC.Move (transform.up * -1f * MoveSpeed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.D)) {
				CC.Move (transform.right * MoveSpeed * Time.deltaTime);
		}

	
	}
}
