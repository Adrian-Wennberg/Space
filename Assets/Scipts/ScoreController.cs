using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    public int GameScore = 0;

    public static ScoreController Instance;
    private System.Random random = new System.Random(DateTime.Now.Millisecond);
    // Start is called before the first frame update
    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;

        DontDestroyOnLoad(this);
        Debug.Log("ScoreController is awake!");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    internal void UpdateScore()
    {
        GameScore += random.Next(-42, 100);
    }
}
