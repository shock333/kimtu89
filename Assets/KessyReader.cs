using UnityEngine;
using System.Collections;
using System.IO;

public class KessyReader : MonoBehaviour {

	private int kessyMode; // 0: tutorial 1: normal
	private int key; // 11: tutorial 1, 12: tutorial 2, 13:tutorial 3
	private StreamReader fReader;
	private string tempContents;
	// Use this for initialization
	void Start () {
		//tempContents = "";
		kessyMode = 0;
		if (kessyMode == 0) {
			key = 11;
			readFile (key);
			GameObject.Find ("kessyTalk").GetComponent<kessyTalk> ().startRead (tempContents);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown(){
		key++;
		GameObject.Find ("kessyTalk").GetComponent<kessyTalk> ().eraseText ();
		readFile (key);
		GameObject.Find ("kessyTalk").GetComponent<kessyTalk> ().startRead (tempContents);

	}

	void readFile(int key){
		tempContents = "";
		int convertKey = key - 10;
		fReader = new StreamReader ("Kessytalk" + convertKey.ToString() + ".txt");
		while (fReader.Peek() > -1) {
			tempContents = tempContents + fReader.ReadLine() + "\n";
		}
		
		fReader.Close ();
	}
}
