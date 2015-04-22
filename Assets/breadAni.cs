using UnityEngine;
using System.Collections;

public class breadAni : MonoBehaviour {
	protected  Animator animator ;
	public bool isAttacked;
	bool LMouseclicked;
	// Use this for initialization
	void Start () {
		animator =  GetComponent < Animator > ();
		isAttacked = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {Debug.Log("in");
			LMouseclicked = true;
		}
		else{
			LMouseclicked = false;
		}
		animator .SetBool ("isAttacked", isAttacked);
	}

	void OnTriggerEnter(Collider other){

		if (LMouseclicked && other.gameObject.tag == "AttackCollider") {

			isAttacked = true;
		}
		else isAttacked = false;
	}
	
	void OnTriggerStay(){
	}
	
	void OnTriggerExit(Collider other){
		isAttacked = false;
	}
}
