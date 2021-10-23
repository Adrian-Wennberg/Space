using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BasicMovement : EventMover
{
    public CharacterController controller;
    public List<Transform> playerPositions;
    private float speed = 1.8f;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        //StartCoroutine(BasicMove());
        SceneController.Instance.onStep += onStep;
    }

    private void onStep(string _)
    {
        var step = SceneController.Instance.CurrentStep;
        var time = SceneController.Instance.stepTimes[step];
        anim.SetBool("Walking", (transform.position - playerPositions[step].position).sqrMagnitude > 1f);
        MoveTo(playerPositions[step], time);
    }


    public IEnumerator BasicMove()
    {
        float smooth = 5.0f;

        var startTimer = 0f;
        anim.SetBool("Walking", true);
        while (startTimer < 4.2)
        {
            transform.Translate(Vector3.forward *speed * Time.deltaTime);

            yield return null;
            startTimer += Time.deltaTime;
        }
        anim.SetBool("Walking", false);

        Vector3 rotationLeft = new Vector3(0, -15, 0);
        Vector3 rotationRight = new Vector3(0, 15, 0);
        transform.Rotate(rotationLeft);
        transform.Rotate(rotationLeft);
        transform.Rotate(rotationLeft);
        transform.Rotate(rotationLeft);
        transform.Rotate(rotationLeft);
        transform.Rotate(rotationLeft);

        yield return new WaitForSeconds(5);

        transform.Rotate(rotationRight);
        transform.Rotate(rotationRight);
        transform.Rotate(rotationRight);
        transform.Rotate(rotationRight);
        transform.Rotate(rotationRight);
        transform.Rotate(rotationRight);


        var walkOutTimer = 0f;
        anim.SetBool("Walking", true);
        while (walkOutTimer < 4)
        {
            transform.Translate(Vector3.forward * 5.5f * Time.deltaTime);

            yield return null;
            walkOutTimer += Time.deltaTime;
        }
        anim.SetBool("Walking", false);


    }
}
