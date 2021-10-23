using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelSwap : EventTrigger
{
    public GameObject original;
    public GameObject swapped;
    public AudioSource audioSource;

    new void Start()
    {
        base.Start();
        original.SetActive(true);
        swapped.SetActive(false);
    }

    protected override void OnSpacebar()
    {
        base.OnSpacebar();
        original.SetActive(false);
        swapped.SetActive(true);
        if(audioSource !=  null)
            audioSource.Play();
    }

}
