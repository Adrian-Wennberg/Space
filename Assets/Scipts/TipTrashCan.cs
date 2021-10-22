using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipTrashCan : EventTrigger
{
    public GameObject standing;
    public GameObject tipped;
    public AudioSource gunShot;

    
    protected override void OnSpacebar()
    {
        standing.SetActive(false);
        tipped.SetActive(true);
        gunShot.Play();
    }
}
