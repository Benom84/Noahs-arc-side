﻿using UnityEngine;
using System.Collections;




public class MainMenuScript : MonoBehaviour {

	[HideInInspector]
	public enum Button{Quit, Sound, Play, About}

	public Button button;

	void Start() {

		if (button == Button.Sound)
				if (!PlayerPrefs.HasKey ("Sound"))
						PlayerPrefs.SetString ("Sound", "On");

	}

	void OnMouseDown() {
		if (button == Button.Quit)
			Application.Quit ();
		else if (button == Button.Play)
			Application.LoadLevel ("GrassLevel1");
		else if (PlayerPrefs.GetString("Sound") == "On")
			PlayerPrefs.SetString ("Sound", "Off");
		else
			PlayerPrefs.SetString ("Sound", "Off");
	
	}

}
