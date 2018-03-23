using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Guess : MonoBehaviour {

	public Text[] guessTextArray;

	public Answer answer;
	public ResultView view;
	public Button submitButton;

	int GuessTextIndex = 0;

	public void SetNumber(int number)
	{
		if(GuessTextIndex < 3)
		{
			guessTextArray[GuessTextIndex++].text = number.ToString();
		}
	}

	public void ResetNumber()
	{
		if(GuessTextIndex > 0)
		{
			guessTextArray[--GuessTextIndex].text = null;
		}
	}

	public void Submit()
	{
		int[] guessArray = new int[3];

		GuessTextIndex = 0;

		guessArray[0] = int.Parse(guessTextArray[0].text);
		guessArray[1] = int.Parse(guessTextArray[1].text);
		guessArray[2] = int.Parse(guessTextArray[2].text);

		for(int i = 0; i < 3; i++)
		{
			guessTextArray[i].text = null;
		}

		if(guessArray[0] == guessArray[1] || guessArray[0] == guessArray[2] || guessArray[1] == guessArray[2])
		{
			view.DisplayWarning();

			return;
		}

		Result result = answer.CompareToAnswer(guessArray);

		if(result.Strike == 3)
		{
			submitButton.interactable = false;
		}

		view.DisplayResult(result);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
