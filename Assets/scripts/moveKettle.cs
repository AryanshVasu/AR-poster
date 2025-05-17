using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveKettle : MonoBehaviour
{
    Vector3 meanPos;
    float timescale=0.75f;
    void Start(){
        meanPos = transform.localPosition;
    }

    void Update()
    {
        transform.localPosition = meanPos + new Vector3(0, Mathf.Sin(Time.time*timescale)/10, Mathf.PerlinNoise(Time.time*timescale*0.8f,5)/25);
    }
}
