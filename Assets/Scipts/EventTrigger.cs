using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EventTrigger : MonoBehaviour
{
    public string triggerString;
    private bool running;
    public bool Triggered { get; protected set; }

    protected void Start()
    {
        SceneController.Instance.onStep += onStep;
        Triggered = false;
    }

    private void onStep(string stepName)
    {
        Debug.Log("On Step Trigger: " + stepName);
        if (stepName == triggerString)
        {
            Spacebar.Instance.OnSpacebar += OnSpacebar;
            running = true;
        }
        else if (running)
        {
            Spacebar.Instance.OnSpacebar -= OnSpacebar;
            OnCons();
            running = false;
        }
    }

    protected virtual void OnSpacebar()
    {
        Triggered = true;
        Debug.Log("On Space Trigger: " + triggerString);
    }

    protected virtual void OnCons(){}
}
