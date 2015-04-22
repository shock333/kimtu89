using UnityEngine;
using System.Collections;

public class GuiCredits : MonoBehaviour {

	public Texture ButtonOrigin;
	public Texture ButtonNew;
	
	Rect ScreenRect;
	// Use this for initialization
	void Start () {
		ButtonOrigin = guiTexture.texture;
		ScreenRect.x = Screen.width / 2 - guiTexture.pixelInset.width / 2;
		ScreenRect.y = (Screen.height / 16)*3 - guiTexture.pixelInset.height / 2;
		ScreenRect.width = guiTexture.pixelInset.width;
		ScreenRect.height = guiTexture.pixelInset.height;
		guiTexture.pixelInset = ScreenRect;
		Debug.Log (ScreenRect);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnMouseEnter(){
		guiTexture.texture = ButtonNew;
	}
	
	void OnMouseExit(){
		guiTexture.texture = ButtonOrigin;
	}
}
