using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AvatarAbility : MonoBehaviour
{
    public GameObject camera;
    private float walkSpeed = 5f;
    public GameObject[] arr;
    private bool isSizeZero = true;
    bool shouldStop = false;

    void Start()
    {
        isGameObjectArraySizeZero();
    }

    void Update()
    {
        if (isSizeZero == false)
        {
            shouldStop = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].GetComponent<MoveMediationPoint>().isEntered == true)
                {
                    shouldStop = true;
                    break;
                }
            }
        }
        if (shouldStop != true && camera.transform.localEulerAngles.x > 25 && camera.transform.localEulerAngles.x < 55)
        {
            float y = camera.transform.localEulerAngles.y;
            transform.position += new Vector3(Trigo(y, 1), 0, Trigo(y, 0));

        }

    }

    public void isGameObjectArraySizeZero()
    {
        if (arr.Length == 0)
        {
            isSizeZero = true;
        }
        else if (arr.Length != 0)
        {
            isSizeZero = false;
        }
    }

    float Trigo(float y, int flag)
    {
        if (flag == 1)
        {
            return Mathf.Sin(y * Mathf.Deg2Rad) * walkSpeed * Time.deltaTime;
        }
        else if (flag == 0)
        {
            return Mathf.Cos(y * Mathf.Deg2Rad) * walkSpeed * Time.deltaTime;
        }
        else
            return -1;
    }
}
