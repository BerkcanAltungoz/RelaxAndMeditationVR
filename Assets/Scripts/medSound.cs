using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class medSound : MonoBehaviour
{
    bool flag = true;
    bool isSit;
    public MoveMediationPoint movemeditationpoint;
    public AudioSource playSound;
    
    // Start is called before the first frame update
    void Start()
    {
      //  movemeditationpoint = this.GetComponent<MoveMediationPoint>();
    }

    // Update is called once per frame
    void Update()
    {
        isSit = movemeditationpoint.isSitting;
        if (isSit && flag)
        {
            playSound.Play();
            flag = false;
            Debug.Log("trigger");
        }
        else if (!isSit)
        {
            playSound.Stop();
            flag = true;
            Debug.Log("false");
        }
    }
}
