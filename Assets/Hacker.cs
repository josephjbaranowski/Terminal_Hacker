using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

	// Use this for initialization
	void Start () {
		ShowMainMenu();
	}
	void ShowMainMenu (){
		Terminal.ClearScreen();
		Terminal.WriteLine("What will you hack?");
		Terminal.WriteLine("Press 1 for School");
		Terminal.WriteLine("Press 2 for the DMV");
		Terminal.WriteLine("Press 3 for Millenium Falcon");
		Terminal.WriteLine("Enter your selection:");
	}
	// Update is called once per frame
	void Update () {
		
	}
}
