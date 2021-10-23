using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{

    public List<string> sceneSteps;
    public List<int> stepTimes;
    public static SceneController Instance { get; private set; }
    public int CurrentStep => currentStep;

    private int currentStep = 0;
    public string nextScene;
    public Action<string> onStep;

    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PlayScene());
    }


    // Update is called once per frame
    void Update()
    {
    }

    public IEnumerator PlayScene()
    {
        while (currentStep < sceneSteps.Count)
        {
            onStep?.Invoke(sceneSteps[currentStep]);
            Debug.Log("Step: " + sceneSteps[currentStep]);
            yield return new WaitForSeconds(stepTimes[currentStep]);
            currentStep++;
        }

        GameController.Instance.StartScene(nextScene);
    }
}
