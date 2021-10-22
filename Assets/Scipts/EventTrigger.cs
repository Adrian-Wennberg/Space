using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EventTrigger : MonoBehaviour
{
    public string triggerString;
    private bool running = false;

    void Start()
    {
        SceneController.Instance.onStep += onStep;
    }

    private void onStep(string stepName)
    {
        if (stepName == triggerString)
        {
            Spacebar.Instance.OnSpacebar += OnSpacebar;
            running = true;
        }
        else if (running)
        {
            Spacebar.Instance.OnSpacebar -= OnSpacebar;
            running = false;
        }
    }

    protected abstract void OnSpacebar();
}
