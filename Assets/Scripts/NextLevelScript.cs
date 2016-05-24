using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NextLevelScript : MonoBehaviour 
{
	public void NextLevelButton(string levelName)
	{
		GameObject.Find ("GameManager").GetComponent<TouchInputHandler> ().endSequence ();
		Application.LoadLevel(levelName);
	}
}