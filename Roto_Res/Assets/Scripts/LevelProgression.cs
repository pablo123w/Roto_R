using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelProgression : MonoBehaviour
{
    public float GooberConstraint = 1;

    public float Score = 0;
    public float ScorePercent = 0;

    public Image GooberConstraintImage;
    public Image GooberSavedImage;

    public GameObject NextLevelButton;

    private GameObject[] TotalGoobers;
    float GoobCount = 0.0f;
    float TotalGoobHP;
    float TotalGoobHPMax;

    public void Start()
    {
        GooberConstraintImage.fillAmount = GooberConstraint;

        // Tracks the amount of the goobers in the scene.
        TotalGoobers = GameObject.FindGameObjectsWithTag("C_Goober");

        GoobCount = TotalGoobers.Length;
        Debug.Log("goobcount is " + GoobCount);

        TotalGoobHPMax = GoobCount * 100;
        Debug.Log("total hp max: " + TotalGoobHPMax);
        TotalGoobHP = TotalGoobHPMax;
        Debug.Log("total goob HP at start: " + TotalGoobHP);
    }

    public void LoseBlood(float impact)
    {
        TotalGoobHP -= impact;
        Debug.Log("total goob hp after losing blood: " + TotalGoobHP);
        GooberConstraint = TotalGoobHP / TotalGoobHPMax;
        Debug.Log("goober constraint: " + GooberConstraint);

        GooberConstraintImage.fillAmount = GooberConstraint;
    }
    public void AddGoober(float collectedhp)
    {
        Score += collectedhp;
        Debug.Log("score is: " + Score);
        ScorePercent = (Score/100)/((TotalGoobHPMax)/100);
        Debug.Log("added " + collectedhp);
        GooberSavedImage.fillAmount = ScorePercent;
	}
}
