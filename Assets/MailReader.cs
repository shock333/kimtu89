using UnityEngine;
using System.Collections;

public class MailReader : MonoBehaviour {

	private int charNumb;
	private float readingSPD;
	// Use this for initialization
	void Start () {
		charNumb = 0;
		guiText.text = "";
		readingSPD = 0.1f;
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void startRead(Mail myMail){
		StartCoroutine("readMail", myMail);
	}

	IEnumerator readMail(Mail myMail){
		while(true){
			yield return new WaitForSeconds (readingSPD);
			guiText.text = guiText.text + myMail.getMail () [charNumb];
			charNumb++;
			if(charNumb>=myMail.getMail ().Length){
				charNumb = 0;
				break;
			}
		}
	}
}
