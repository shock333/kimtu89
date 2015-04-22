using UnityEngine;
using System.Collections;

public class attackAni : MonoBehaviour {
	protected  Animator animator ;

	// Use this for initialization
	void Start () {
		animator =  GetComponent < Animator > ();
	}
	
	// Update is called once per frame
	void Update () {
		//animation.CrossFade("idle");

		//animation.CrossFade ("attackAni");

		if (!animation.isPlaying) {

			Destroy(this);
		}
	}



}

