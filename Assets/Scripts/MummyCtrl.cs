using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MummyCtrl : MonoBehaviour
{
    public bool isWalking = false;
    public Animator animator;

    public void OnClickWalking()
    {
        isWalking = !isWalking; // isWalking = not isWalking
        animator.enabled = isWalking;
    }
}
