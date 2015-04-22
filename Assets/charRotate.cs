using UnityEngine;
using System.Collections;

public class charRotate : MonoBehaviour {
	private Quaternion dir;
	private RaycastHit Hit;
	private Vector3 mPos;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		/*Vector3 pPos = transform.position;

		Physics.Raycast (Camera.main.ScreenPointToRay (Input.mousePosition), out Hit);

		mPos = Hit.point;
		mPos.z = pPos.z;
*/
		Vector3 pz = Camera.main.ScreenToWorldPoint(Input.mousePosition);		
		gameObject.transform.rotation = Quaternion.LookRotation(Vector3.forward ,pz - transform.position);



		//gameObject.transform.position = pz; 
	}
}
