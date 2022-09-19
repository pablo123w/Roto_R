using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Goobtube : MonoBehaviour
{
    public int Score;
    public TMP_Text score_text;
    void Start()
    {
        Score = 0;
        UpdateScoreText();
    }

    public void UpdateScoreText()
    {
        score_text.text = "Number of Goobers Saved: " + Score.ToString();
    }

    public void OnTriggerEnter(Collider other)
	{
		if(other.CompareTag("Goober"))
		{
            Debug.Log("is working");
            Score++;
            UpdateScoreText();
            Destroy(other.transform.root.gameObject);
		}
	}
}
