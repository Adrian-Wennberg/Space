using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressBar : MonoBehaviour
{
    public List<string> triggerString;
    private bool running = false;
    public CircularProgressBar progressBar;
    public GameObject Arrow;

    void Start()
    {
        SceneController.Instance.onStep += onStep;
        progressBar.gameObject.SetActive(false);
        Arrow.gameObject.SetActive(false);
        Spacebar.Instance.OnSpacebar += OnSpacebar;
    }

    private void onStep(string stepName)
    {
        if (triggerString.Contains(stepName))
        {
            progressBar.active = true;
            running = true;
            progressBar.gameObject.SetActive(true);
            Arrow.gameObject.SetActive(true);
        }
        else if (running)
        {

            progressBar.active = false;
            running = false;
            progressBar.gameObject.SetActive(false);
            Arrow.gameObject.SetActive(false);
        }
    }
    protected void OnSpacebar()
    {
        progressBar.active = false;
    }
}
