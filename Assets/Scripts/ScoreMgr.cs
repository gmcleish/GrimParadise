using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreMgr : MonoBehaviour {

	public float score;
	public Text	scoreText;

	void OnEnable() {
		score = 0;
	}

	public void IncScore()
	{
		score += Time.deltaTime;

		if (scoreText != null)
		{
			scoreText.text = score.ToString();
		}
	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		IncScore();
	}
}
