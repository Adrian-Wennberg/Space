using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreUpdater : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var score = ScoreController.Instance.GameScore;
        var text = "Score: " + score;
        GetComponent<TextMeshProUGUI>().text = text;
    }
}
