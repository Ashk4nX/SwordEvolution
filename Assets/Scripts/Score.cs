using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public int ScoreValue;
	private Text scoreText;

	// Use this for initialization
	void Start () {

		scoreText = GameObject.FindObjectOfType<Text> ();
		ScoreValue = 10;
		scoreText.text = ScoreValue.ToString ();

	}
	
	// Update is called once per frame
	void Update () {


		
	}
}
