using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Teleport : MonoBehaviour
{
    bool isEntered = false;
    float tpTime = 4f;
    float menteseSpeed = 30f;
    public GameObject ment;
    public string tpArea;

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
        if (isEntered == true)
        {
            tpTime = tpTime - Time.deltaTime;
            if (ment.transform.localRotation.y < 0.8f)
                ment.transform.Rotate(Vector3.up * menteseSpeed * Time.deltaTime);
            if (tpTime <= 0f)
            {
                SceneManager.LoadScene(tpArea);
            }
        }

        if (isEntered == false)
        {
            if (ment.transform.localRotation.y > 0f)
                ment.transform.Rotate(Vector3.down * menteseSpeed * Time.deltaTime);
            tpTime = 4f;
        }
    }
}
