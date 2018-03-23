using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Result
{
	public int[] Guess;
	public int Strike;
	public int Ball;
	public int Out;
}

public class ResultView : MonoBehaviour {

	int submitCount = 0;

	public Transform Contact;

	public GameObject ResultItem;
	public GameObject EndItem;
	public GameObject WarningItem;

	public Score score;

	public Image[] ResultIcon;
	public Color StrikeColor;
	public Color BallColor;
	public Color OutColor;

	public void DisplayResult(Result result)
	{
		submitCount++;

		if(result.Strike == 3)
		{
			GameObject obj = Instantiate(EndItem, Contact);
			obj.GetComponentInChildren<Text>().text = submitCount + "번째만에 정답을 맞추셨습니다.";
		}
		else
		{
			GameObject obj = Instantiate(ResultItem, Contact);
			obj.GetComponent<ResultItem>().Setup(submitCount, result);
			score.Lost_Score();
		}

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

	public void DisplayWarning()
	{
		Instantiate(WarningItem,Contact);
	}

}
