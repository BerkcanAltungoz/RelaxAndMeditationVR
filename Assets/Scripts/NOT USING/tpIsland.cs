using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class tpIsland : MonoBehaviour
{
    bool isEntered = false;
    float tpTime = 4f;
    float menteseSpeed = 29f;
    public GameObject ment;

    public void enter()
    {
        isEntered = true;
    }

    public void exit()
    {
        isEntered = false;
    }

    void Update()
    {
        if(isEntered == true)
        {
            tpTime = tpTime - Time.deltaTime;
            if (ment.transform.localRotation.y < 0.8f)
                ment.transform.Rotate(Vector3.up * menteseSpeed * Time.deltaTime);
            if(tpTime <= 0f)
            {
                SceneManager.LoadScene("Island");
            }
        }

        if(isEntered == false)
        {
            if (ment.transform.localRotation.y > 0f)
                ment.transform.Rotate(Vector3.down * menteseSpeed * Time.deltaTime);
            tpTime = 4f;
        }
    }
}
