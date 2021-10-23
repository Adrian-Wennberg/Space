using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public enum GameState
    {
        Menu,
        Ended,
        Playing
    }

    public GameState State;

    public static GameController Instance;
    // Start is called before the first frame update
    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        State = GameState.Menu;
        DontDestroyOnLoad(this);
        Debug.Log("GameController is awake!");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void StartScene(string scene)
    {
        //Spacebar.Instance.OnSpacebar = null;
        Debug.Log("Starting Scene: " + scene);
        SceneManager.LoadScene(scene);
    }
}
