using UnityEngine;
using System.Collections;


public class kessyTalk : MonoBehaviour {

	private int charNumb;
	private float readingSPD;
	private bool stopReading;

	// Use this for initialization
	void Start () {
		stopReading = false;
		guiText.text = "";
		readingSPD = 0.1f;
		charNumb = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void eraseText(){
		stopReading = true;
		guiText.text = "";
		StopCoroutine ("readTutorialTalk");
	}

	public void startRead(string contents){

		StartCoroutine("readTutorialTalk", contents);
	}
	
	IEnumerator readTutorialTalk(string contents){

		while(true){Debug.Log (contents);
			if(stopReading){
				guiText.text = "";
				charNumb = 0;
				stopReading = false;
				yield break;
			}

			yield return new WaitForSeconds (readingSPD);

			guiText.text = guiText.text + contents[charNumb];
			charNumb++;
			if(charNumb>=contents.Length){
				charNumb = 0;
				break;
			}
		}
	}


}
