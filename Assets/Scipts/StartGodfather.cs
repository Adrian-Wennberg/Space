using UnityEngine;

public class StartGodfather : EventTrigger
{
    public AudioSource godfather;
    
    protected override void OnSpacebar()
    {
        godfather.Play();
        DontDestroyOnLoad(gameObject);
    }
}
