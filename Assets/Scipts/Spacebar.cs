using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spacebar : MonoBehaviour
{
    public static Spacebar Instance;

    public Action OnSpacebar;
    // Start is called before the first frame update
    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnSpacebar?.Invoke();
        }
    }
    
}
