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

    private bool lastTouch = false;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || (!lastTouch && Input.touchCount == 1))
        {
            OnSpacebar?.Invoke();
        }

        lastTouch = Input.touchCount == 1;
    }
    
}
