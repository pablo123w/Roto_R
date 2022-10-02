using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelProgression : MonoBehaviour
{
    public float gooberConstraint = 1;
    public float gooberSaved = 0;

    public Image GooberConstraintImage;
    public Image GooberSavedImage;

    public GameObject NextLevelButton;

    // Start is called before the first frame update
    void Start()
    {
        
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

        if (gooberSaved >= 0.5f)
        {
            ButtonActive();
        }
    }

    public void ButtonActive()
    {
            NextLevelButton.SetActive(true);
    }
}
