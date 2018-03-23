using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultItem : MonoBehaviour {
	public Text RoundText;

	public Color StrikeColor;
	public Color BallColor;
	public Color OutColor;

	public Image[] ResultIcon;

	public void Setup(int submitCount, Result result)
	{
		RoundText.text = string.Format("{0} Round : {1}, {2}, {3}", submitCount, result.Guess[0], result.Guess[1], result.Guess[2]);

		int index = 0;

		for(int i = 0; i < 3; i++)
		{
			if(i < result.Strike)
			{
				ResultIcon[i].color = StrikeColor;
			}
			else if(i < result.Strike + result.Ball)
			{
				ResultIcon[i].color = BallColor;
			}
			else
			{
				ResultIcon[i].color = OutColor;
			}
		}
	}
}
