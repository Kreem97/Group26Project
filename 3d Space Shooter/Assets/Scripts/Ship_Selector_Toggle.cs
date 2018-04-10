using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship_Selector_Toggle : MonoBehaviour {

	public GameObject shipSelector;

	// Use this for initialization
	void Start ()
	{
		shipSelector.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		//enemy info toggle
		if(Input.GetKeyDown (KeyCode.C))
		{
			if (shipSelector.activeSelf) {
				shipSelector.SetActive (false);
			}
			else
			{
				shipSelector.SetActive (true);
			}
		}
	}
}
