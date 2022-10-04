using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Goobtube : MonoBehaviour
{
    public float Score;
    public TMP_Text score_text;
    private float collectedhp;

    public GameObject Canvas;
    LevelProgression LP;
    
    void Start()
    {
        LP = Canvas.GetComponent<LevelProgression>();
        Score = 0;
        UpdateScoreText();
        
    }

    public void UpdateScoreText()
    {
        score_text.text = "Number of Goobers Saved: " + Score.ToString();
    }

    public void OnTriggerEnter(Collider other)
	{
		if(other.CompareTag("C_Goober"))
		{
            Debug.Log("tube recognize goob");
            collectedhp = other.transform.root.GetComponent<goobScript>().goobhp;
            LP.AddGoober(collectedhp);
            
            Debug.Log(collectedhp);
            
            UpdateScoreText();
            Destroy(other.transform.root.gameObject);
		}
	}
}
