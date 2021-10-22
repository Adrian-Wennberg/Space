using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 1f;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        StartCoroutine(BasicMove());
    }

    // Update is called once per frame
    void Update()
    {
    }


    public IEnumerator BasicMove()
    {
        var t = 0f;
        anim.SetBool("Walking", true);
        while (t < 5.3)
        {
            transform.Translate(0, 0, speed * Time.deltaTime);

            yield return null;
            t += Time.deltaTime;
        }
        anim.SetBool("Walking", false);
    }
}
