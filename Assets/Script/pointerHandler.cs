using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class pointerHandler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
	[SerializeField] public cameraMovement script;

	public void OnPointerEnter(PointerEventData eventData)
	{
		// print("pointer on UI");
		script.moveActive = false;
	}

	public void OnPointerExit(PointerEventData eventData)
	{
		// print("pointer not over UI");
		script.moveActive = true;
	}
}
