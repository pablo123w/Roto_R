using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelProgression : MonoBehaviour
{
    public float gooberConstraint = 1;
    public float gooberSaved = 0;

    public float ScorePercent = 0;
    //public int totalGoobers;

    public Image GooberConstraintImage;
    public Image GooberSavedImage;

    public GameObject NextLevelButton;
    public List <GameObject>TotalGoobers = new List<GameObject>();
    float GoobCount;
    float TotalGoobHP;

    // Start is called before the first frame update
    void Start()
    {
        // Tracks the amount of the goobers in the scene.
        TotalGoobers.Add(GameObject.FindGameObjectWithTag("C_Goober"));
        GoobCount = TotalGoobers.Count;
        Debug.Log(GoobCount + " Goober(s) are in the scene.");
        TotalGoobHP = GoobCount * 100;
        Debug.Log(TotalGoobers);
        if (TotalGoobers == null)
        {
            TotalGoobers.Add(GameObject.FindGameObjectWithTag("C_Goober"));
        }
    }

    // Update is called once per frame
    void Update()
    {
        // This adds to the yellow bar (Goobers Saved) and stops it at the goober constraint (Grey Bar)
        if (Input.GetKeyDown(KeyCode.Space) && gooberSaved <= gooberConstraint)
        {
            Debug.Log("Space was pressed.");
            gooberSaved += 0.1f;
            GooberSavedImage.fillAmount = gooberSaved;
        }
        
        

        // This shrinks the goober constraint acting as if goobers lost blood (health)
        if (Input.GetKeyDown(KeyCode.N))
        {
            Debug.Log("N was pressed. Goober Constraint should shrink.");
            gooberConstraint -= 0.1f;
            GooberConstraintImage.fillAmount = gooberConstraint;
        }
        // If 50% or more goobers have been saved then the next level button is revealed.
        if (gooberSaved >= ScorePercent)
        {
            // 50% Goobers saved, Button Active x1
            ButtonActive();
        }

        ///////////////////////////////////////////////////////Testing with GOOBERS//////////////////////////////////////////////////////

        
        

        /*if (gooberSaved >= totalGoobers)
        {
            ButtonActive();
        }
        */
    }
    
    // Selecting this button changes the current scene to the next one.
    public void ButtonActive()
    {
        // Button Active function called
            NextLevelButton.SetActive(true);
    }

    //void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.tag == "Goober") 
    //    {
    //        gooberSaved += 0.1f;
    //        Debug.Log("A Goober was hit!");
    //    }
    //}

    public void AddGoober(float collectedhp)
    {
        Debug.Log("add goober");
        ScorePercent = collectedhp / TotalGoobHP * 100;
        Debug.Log(ScorePercent + "%");

        if (gooberSaved <= ScorePercent)
        {
            Debug.Log("Score increased.");

            GooberSavedImage.fillAmount = ScorePercent;
        }
    }
}
