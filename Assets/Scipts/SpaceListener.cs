using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceListener : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Spacebar.Instance.OnSpacebar += OnSpacebar;
    }

    private void OnSpacebar()
    {
        GameController.Instance.State = GameController.GameState.Playing;
        GameController.Instance.StartScene("StartingScene");
        Spacebar.Instance.OnSpacebar -= OnSpacebar;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
