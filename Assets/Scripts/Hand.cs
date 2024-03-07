using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Hand : MonoBehaviour
{
    //animation
    [SerializeField] public float animationSpeed;
    Animator animator;
    private float triggerTarget;
    private float gripTarget;
    private float triggerCurrent;
    private float gripCurrent;
    private string animatorGripParam = "Grip";
    private string animatorTriggerParam = "Trigger";

    void Start()
    {
        animator = GetComponent<Animator>();
    }


    private void Update()
    {
        AnimateHand();



    }
    internal void SetGrip(float v)
    {
        gripTarget = v;
    }

    internal void SetTrigger(float v)
    {
        triggerTarget = v;
    }

    void AnimateHand()
    {
        if (gripCurrent!= gripTarget)
        {
            gripCurrent = Mathf.MoveTowards(gripCurrent, gripTarget, Time.deltaTime * animationSpeed);
            animator.SetFloat(animatorGripParam, gripCurrent);

        }
        if (triggerCurrent!= triggerTarget)
        {
            triggerCurrent = Mathf.MoveTowards(triggerCurrent, triggerTarget, Time.deltaTime * animationSpeed);
            animator.SetFloat(animatorTriggerParam, triggerCurrent);

        }
}
}
