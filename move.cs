using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
	public float speed = 1;
	public float height = 1;
	public float sensitivity= 1;
	//public float camlimit = 60f;
	float camrot = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {



		float speed = Time.deltaTime * sensitivity;
		float rlrot  = Input.GetAxis("Mouse X")*speed;
		float camrot = Input.GetAxis ("Mouse Y")*speed;
		float forward = Input.GetAxis ("Vertical") * speed;
		float side = Input.GetAxis ("Horizontal") * speed;

		//camrot = Mathf.Clamp (camrot, -camlimit, camlimit);


		//Camera.main.transform.Rotate (-updownrot, 0,0);
		transform.Rotate (-camrot, 0, 0);

		//Camera.main.transform.localRotation= Quaternion.Euler (camrot,0,0);


						/*float move = Time.deltaTime * speed;

						if (Input.GetKey (KeyCode.W)) {
		
								transform.Translate (0, 0, 1 * move, Space.Self);
						}
						if (Input.GetKey (KeyCode.S)) {
			
								transform.Translate (0, 0, -1 * move, Space.Self);
						}

						if (Input.GetKey (KeyCode.A)) {
			
								transform.Translate (-1 * move, 0, 0, Space.Self);
						}

						if (Input.GetKey (KeyCode.D)) {
			
								transform.Translate (1 * move, 0, 0, Space.Self);
						}
				

						if (Input.GetKey (KeyCode.Space)) {
			
								transform.Translate (0, 1 * height, 0, Space.Self);
						}*/
						transform.Rotate (0, -rlrot, 0);

		Vector3 fast = new Vector3 (side,0,forward);
		fast= transform.rotation* fast;

		CharacterController cc = GetComponent<CharacterController> ();

			cc.Move (fast*Time.deltaTime)
						
	
	}
}
