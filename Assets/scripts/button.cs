using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    Animator backAnimator;

    void Start(){
        backAnimator = GetComponent<Animator>();
    }
    public void pourCoffee(){
        backAnimator.SetTrigger("play");
    }
}
