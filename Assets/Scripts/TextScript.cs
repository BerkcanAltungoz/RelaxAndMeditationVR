using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour
{
    public Text walkInfo;
    Vector3 startPosition;
    float distance;
    public GameObject startpPositionAvatar;
    float startTime = 7;
    void Start()
    {
        walkInfo.GetComponent<Animator>().enabled = false;
        walkInfo.GetComponent<Text>().enabled = false;
    }

    void Update()
    {
        distance = Vector3.Distance(this.transform.position, startpPositionAvatar.transform.position);
        if(distance > 6f)
        {
            walkInfo.GetComponent<Animator>().enabled = false;
            walkInfo.GetComponent<Text>().enabled = false;
            this.GetComponent<TextScript>().enabled = false;
        }
        else if (distance <= 6f && startTime > 0f)
        {
            startTime = startTime - Time.deltaTime;
        }
        else if (distance <= 6f && startTime <= 0f) 
        {
            walkInfo.GetComponent<Text>().enabled = true;
            walkInfo.GetComponent<Animator>().enabled = true;
        }
    }
}
