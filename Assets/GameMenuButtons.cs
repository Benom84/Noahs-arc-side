using UnityEngine;
using System.Collections;

public class GameMenuButtons : MonoBehaviour {

	public enum GameMenuButton {Resume, MainMenu, Sound, Effects}
	public GameMenuButton button;

	private Pauser pauser;
	// Use this for initialization
	void Start () {
		pauser = GameObject.Find ("MenuButton").GetComponent("Pauser");

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
