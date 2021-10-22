using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    public static GameController Instance;
    // Start is called before the first frame update
    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }

        Instance = this;
        Debug.Log("GameController is awake!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
