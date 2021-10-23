using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventMover : EventTrigger
{
    public GameObject mover;
    
    protected IEnumerator MoveTo(Vector3 pos, float time)
    {
        return move(pos, time);
    }


    protected void MoveTo(Transform transform, float time)
    {
        StartCoroutine(move(transform.position, time));
        StartCoroutine(rotate(transform.forward, time));
    }

    private IEnumerator move(Vector3 pos, float time)
    {
        Vector3 moveDir = pos - mover.transform.position;
        var currTime = 0f;

        while (currTime < time)
        {
            mover.transform.Translate(moveDir * Time.deltaTime / time, Space.World);
            currTime += Time.deltaTime;
            yield return null;
        }

        mover.transform.position = pos;
    }


    private IEnumerator rotate(Vector3 lookDirection, float time)
    {
        var axis = Vector3.Cross(mover.transform.forward, lookDirection);
        var angle = Vector3.Angle(mover.transform.forward, lookDirection);
        var currTime = 0f;

        while (currTime <= time)
        {
            mover.transform.Rotate(axis, angle / time * Time.deltaTime );
            currTime += Time.deltaTime;
            yield return null;
        }

        mover.transform.rotation = Quaternion.LookRotation(lookDirection);
    }
}
