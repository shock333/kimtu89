using UnityEngine;
using System.Collections;

public class startBtn : MonoBehaviour {

	public void SecneLoad()
	{
		Application.LoadLevel(Application.loadedLevel + 1); 
	}

}
