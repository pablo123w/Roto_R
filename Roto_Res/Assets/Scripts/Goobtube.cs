using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Goobtube : MonoBehaviour
{
    public float Score;
    public TMP_Text score_text;
    private float collectedhp;
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
            Debug.Log("Goober picked up");
            collectedhp = other.transform.root.GetComponent<goobScript>().goobhp;
            Score = Score + collectedhp;
            
            Debug.Log(collectedhp);
            
            UpdateScoreText();
            Destroy(other.transform.root.gameObject);
		}
	}
}
