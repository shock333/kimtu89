using UnityEngine;
using System.Collections;

public class NextIntro : MonoBehaviour {

	private float fadeOutTime;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown(){

		fadeOutTime = GameObject.Find ("fadeOut").GetComponent<Fading> ().BeginFade (1);
		StartCoroutine("delayTimeFadeIn", fadeOutTime);
		//Debug.Log ("inin");
	}

	IEnumerator delayTimeFadeIn(float fadeTime){
		Debug.Log ("fade out time:" + fadeTime);
		yield return new WaitForSeconds (fadeTime);
		float fadeInTime = GameObject.Find ("fadeOut").GetComponent<Fading> ().BeginFade (-1);
		Debug.Log ("fade in time:" + fadeInTime);
		Destroy (gameObject);
	}
}
