using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : EventMover
{
    public Transform endPos;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        base.Start();
        anim = GetComponent<Animator>();
        //StartCoroutine(BasicMove());
    }

    protected override void OnCons()
    {
        Debug.Log("test");
        StartCoroutine(ZombieWalking());
    }

    private IEnumerator ZombieWalking()
    {
        float time = 1.2f;
        anim.SetBool("Walking", true);
        yield return MoveTo(endPos.position,time);
       // anim.SetBool("Walking", false);
    }
}
