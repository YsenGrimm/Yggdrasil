using UnityEngine;
using System.Collections;

public class MouseListener : MonoBehaviour {

	public float MoveSpeed = 3.0f;
	public float xOffest = 50;
	public float yOffset = 50;

	Rect MouseDeadZone;
	int width = Screen.width;
	int height = Screen.height;
	Vector3 mousePosition = new Vector3();
	GameObject ctrlCamera;

	// Use this for initialization
	void Start () {
		MouseDeadZone = new Rect(xOffest, yOffset, width - (xOffest*2), height - (yOffset*2));
	}
	
	// Update is called once per frame
	void Update () {
		mousePosition = Input.mousePosition;
		Vector3 cameraPosition = Camera.main.transform.position;
		if (mousePosition.x > (MouseDeadZone.x + MouseDeadZone.width)) {
			Camera.main.transform.position = new Vector3(cameraPosition.x + MoveSpeed, cameraPosition.y, cameraPosition.z);
		} else if (mousePosition.x < MouseDeadZone.x) {
			Camera.main.transform.position = new Vector3(cameraPosition.x - MoveSpeed, cameraPosition.y, cameraPosition.z);
		} else if (mousePosition.y < MouseDeadZone.y) {
			Camera.main.transform.position = new Vector3(cameraPosition.x, cameraPosition.y - MoveSpeed, cameraPosition.z);
		} else if (mousePosition.y > (MouseDeadZone.y + MouseDeadZone.height)){
			Camera.main.transform.position = new Vector3(cameraPosition.x, cameraPosition.y + MoveSpeed, cameraPosition.z);
		}
	}
}
