using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimationOnTrigger : MonoBehaviour
{
    public Animator animator;
    public Transform spot;

    private void Update()
    {
        if (transform.position == spot.position)
        {
            animator.SetTrigger("PlayAnimation");
        }
    }
}
