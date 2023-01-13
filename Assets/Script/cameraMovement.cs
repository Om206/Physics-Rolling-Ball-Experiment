using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{
	[SerializeField] public Camera cam;
	[HideInInspector] private Vector3 prevPos;
	[HideInInspector] private float panDistance;
	[HideInInspector] public bool moveActive;

	[SerializeField] KeyCode y1,y2,y3; 
	private void Start()
	{
		panDistance = 10f;
		moveActive = true;
	}

	private void Update()
	{
		if(Input.mouseScrollDelta.y != 0f)
		{
			panDistance -= Input.mouseScrollDelta.y;

			Vector3 direction = Vector3.zero;

			cam.transform.position = Vector3.zero;
			cam.transform.Rotate(new Vector3(1,0,0), direction.y*180);
			cam.transform.Rotate(new Vector3(0,1,0), -direction.x*180, Space.World);
			cam.transform.Translate(new Vector3(0,0,-panDistance));

			prevPos = cam.ScreenToViewportPoint(Input.mousePosition);
		}

		if(Input.GetMouseButtonDown(0) && moveActive)
		{
			prevPos = cam.ScreenToViewportPoint(Input.mousePosition);
		}
		if(Input.GetMouseButton(0) && moveActive)
		{
			Vector3 direction = prevPos - cam.ScreenToViewportPoint(Input.mousePosition);

			cam.transform.position = Vector3.zero;
			cam.transform.Rotate(new Vector3(1,0,0), direction.y*180);
			cam.transform.Rotate(new Vector3(0,1,0), -direction.x*180, Space.World);
			cam.transform.Translate(new Vector3(0,0,-panDistance));

			prevPos = cam.ScreenToViewportPoint(Input.mousePosition);
		}

		if(Input.GetKeyDown(y1))
		{
			print(cam.transform.position);
			cam.transform.position = new Vector3(22.20f, 3.52f, -8.62f);
		}
	}
}
