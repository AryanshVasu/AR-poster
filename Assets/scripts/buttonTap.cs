using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class buttonTap : MonoBehaviour, IPointerDownHandler
{
    public Animator[] anims;
    // InputSystem controls;

    // void Awake(){
    //     control = new InputSystem();
    //     control.Enable();

    //     control.button.buttonTap.performed += ctx => Taped();
    // }

    // public void OnMouseDown(){
    //     Debug.Log("hello");
    //     foreach(Animator a in anims){
    //         a.SetTrigger("play");
    //     }
    // }
    [SerializeField]
    AudioSource audioclip1, audioclip2;

    [SerializeField] 
    TMP_Text msg;


    public void OnPointerDown(PointerEventData eventData) {
        Debug.Log("pointer Down");
        StartCoroutine(playsong());
        audioclip2.volume = 0.7f; 

        foreach (Animator a in anims){
            a.SetTrigger("play");
        }
    }

    IEnumerator playsong(){
        audioclip1.Play();
        yield return new WaitForSeconds(23.3f); //bpm = 79;
        for (int i=0; i<10;i++){
            audioclip1.volume-=0.05f;
            yield return new WaitForSeconds(0.1f);
        }
        yield return new WaitForSeconds(0.83549f);
        StartCoroutine(displaymsg());
    }
    IEnumerator displaymsg(){
        WaitForSeconds wt = new WaitForSeconds((0.83549f)*4);
        WaitForSeconds wt2 = new WaitForSeconds((0.83549f)*2);
        WaitForSeconds wt4 = new WaitForSeconds((0.83549f)/25);
        // for (int i=0;i<20;i++){
        //     msg.text = i.ToString();
        //     yield return wt;
        // }
        msg.text = "Take a breath";
        yield return wt;
        msg.text = "Drink some coffee";
        yield return wt;
        msg.text = "Appreciate the little things accompanying you in your journey";
        // yield return wt2;
        // msg.text = "sound of rain";
        // yield return wt2;
        // msg.text = "smell of soil";
        // yield return wt2;
        // msg.text  = "For the little things make a journey meaningful";
        yield return wt;
        float alpha = 1;
        for (int i=0;i<100;i++){
            alpha -= 0.05f;
            msg.color = new Color(1,1,1,alpha);
            yield return wt4;
        }

    }
}
