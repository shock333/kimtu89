using UnityEngine;
using System.Collections;
using System.IO;

public class MailBox : MonoBehaviour {

	private Mail myMail;
	private string tempContents;
	private StreamReader fReader;
	// Use this for initialization
	void Start () {
		fReader = new StreamReader ("Mailcontents1.txt");
		while (fReader.Peek() > -1) {
			tempContents = tempContents + fReader.ReadLine() + "\n";
		}
		fReader.Close ();
		myMail = new Mail(tempContents);
		//Debug.Log (myMail.getMail ());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown(){
		GameObject.Find ("ReadM").GetComponent<MailReader> ().startRead (myMail);
		Debug.Log (myMail.getMail ());
	}
}
