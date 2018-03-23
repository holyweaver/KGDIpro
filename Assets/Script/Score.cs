using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour {
	Text ScoreText;

	int score = 1000;

	public void Lost_Score()
	{
		score -= 100;

		ScoreText.text = score.ToString();
	}




	// Use this for initialization
	void Start () {
		ScoreText = GetComponent<Text>();
		ScoreText.text = score.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
