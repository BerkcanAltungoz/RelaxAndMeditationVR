using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MoveMediationPoint : MonoBehaviour
{
    public bool isEntered = false;
    float tpTime = 2f;
    float showTime = 3f;
    public GameObject MeditationMat;
    public GameObject Player;
    public GameObject uiTextMessage;
    public bool isSitting = false;
    Color originalMatColor;
    Renderer matRenderer;
    public Text onText;
    public Text offText;
    bool flag = false;
    void Start()
    {
        matRenderer = this.GetComponent<Renderer>();
        originalMatColor = matRenderer.material.color;
    }
    public void enter()
    {
        isEntered = true;
        matRenderer.material.SetColor("_Color", Color.blue);
    }

    public void exit()
    {
        isEntered = false;
        matRenderer.material.SetColor("_Color", originalMatColor);
    }

    public void looking()
    {
        tpTime = tpTime - Time.deltaTime;
        if (tpTime <= 0f)
        {
            uiTextMessage.GetComponent<Canvas>().enabled = true;
            onText.enabled = true;
            flag = true;
            Player.transform.position = new Vector3(MeditationMat.transform.position.x,
                MeditationMat.transform.position.y + 2, MeditationMat.transform.position.z);
            Player.GetComponent<AvatarAbility>().enabled = false;
            isSitting = true;
        }
    }

    void Update()
    {
        
        if(flag == true)
        {
            showTime = showTime - Time.deltaTime;
        }
        if (showTime <= 0f)
        {
            flag = false;
            offText.enabled = false;
            onText.enabled = false;
            uiTextMessage.GetComponent<Canvas>().enabled = false;
            showTime = 3f;
        }
        if (isSitting == false)
        {
            if(isEntered == true)
            {
                tpTime = tpTime - Time.deltaTime;
                if (tpTime <= 0f)
                {
                    uiTextMessage.GetComponent<Canvas>().enabled = true;
                    onText.enabled = true;
                    flag = true;
                    Player.transform.position = new Vector3(MeditationMat.transform.position.x,
                        MeditationMat.transform.position.y + 2, MeditationMat.transform.position.z);
                    Player.GetComponent<AvatarAbility>().enabled = false;
                    isSitting = true;
                    tpTime = 3f;
                }
            }
            else if(isEntered == false)
            {
                tpTime = 3f;
            }
        }
        else if(isSitting == true)
        {
            if (isEntered == true)
            {
                tpTime = tpTime - Time.deltaTime;
                if (tpTime <= 0f)
                {
                    uiTextMessage.GetComponent<Canvas>().enabled = true;
                    offText.enabled = true;
                    flag = true;
                    isSitting = false;
                    Player.GetComponent<AvatarAbility>().enabled = true;
                    tpTime = 3f;
                }
            }
            else if (isEntered == false)
            {
                tpTime = 3f;
            }
        }


    }
}
