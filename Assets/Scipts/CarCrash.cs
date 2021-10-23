using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCrash : EventMover
{
    public Transform carEndPos;
    public Transform carCrashPos;
    public GameObject explosion;
    public AudioSource boom;
    

    protected override void OnCons()
    {
        StartCoroutine(CarDriving());
    }

    private IEnumerator CarDriving()
    {
        var endpos = Triggered ? carCrashPos : carEndPos;
        float time = SceneController.Instance.stepTimes[SceneController.Instance.CurrentStep];
        if (Triggered) time /= 2f;
        Debug.Log("Moving");
        yield return MoveTo(endpos.position, time);

        if(!Triggered)
            yield break;

        Debug.Log("Explode!");
        GameObject exp = Instantiate(explosion, carCrashPos.position + Vector3.up * 3, Quaternion.LookRotation(Vector3.up, Vector3.forward));
        exp.transform.localScale = Vector3.one * 4;
        boom.Play();
    }
    
}
