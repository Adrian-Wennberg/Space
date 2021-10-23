using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepSkipper : MonoBehaviour
{
    public int SkipOnStep;
    public int SkipToStep;
    public int ScoreThreshold;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneController.Instance.CurrentStep == SkipOnStep)
        {
            if (ScoreController.Instance.GameScore > ScoreThreshold)
            {
                Debug.Log("skip to step: " + SkipToStep);
                SceneController.Instance.SkipToStep(SkipToStep);
            }
        }
    }
}
