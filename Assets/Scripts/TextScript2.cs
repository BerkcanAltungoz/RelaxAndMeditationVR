using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript2 : MonoBehaviour
{
    public Text doorInfo;
    float finishTime = 10;
    bool flag = false;
    // Start is called before the first frame update
    void Start()
    {
        doorInfo.GetComponent<Animator>().enabled = false;
        doorInfo.GetComponent<Text>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (flag)
        {
            finishTime = finishTime - Time.deltaTime;
        }

        if(this.transform.position.x >= 320f)
        {
            flag = true;
            doorInfo.GetComponent<Text>().enabled = true;
            doorInfo.GetComponent<Animator>().enabled = true;
        }

        if(finishTime <= 0f)
        {
            Debug.Log("finish");
            doorInfo.GetComponent<Text>().enabled = false;
            doorInfo.GetComponent<Animator>().enabled = false;
            this.GetComponent<TextScript2>().enabled = false;
        }
    }
}
