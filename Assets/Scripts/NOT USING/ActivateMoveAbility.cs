using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateMoveAbility : MonoBehaviour
{
    bool isEntered = false;
    float tpTime = 4f;
    public GameObject movePositionOfRedPoint;
    public GameObject movingObject;
    public GameObject openPoint;
    Vector3 biggerSphereScale = new Vector3(0.25f, 0.25f, 0.25f);
    Vector3 smallerSphereScale = new Vector3(-0.25f, -0.25f, -0.25f);
    Vector3 originalSpehereScale = new Vector3(0.5f, 0.5f, 0.5f);

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
            movePositionOfRedPoint.transform.localScale += biggerSphereScale * Time.deltaTime;
            if (tpTime <= 0f)
            {
                movePositionOfRedPoint.GetComponent<MeshRenderer>().enabled = false;
                movePositionOfRedPoint.GetComponent<SphereCollider>().enabled = false;
                movingObject.GetComponent<walkAvatar>().enabled = true;
                movePositionOfRedPoint.transform.localScale = originalSpehereScale;
                movingObject.transform.position = movePositionOfRedPoint.transform.position;
                openPoint.GetComponent<MeshRenderer>().enabled = true;
                openPoint.GetComponent<SphereCollider>().enabled = true;
            }
        }

        if (isEntered == false)
        {
            if (movePositionOfRedPoint.transform.localScale.x > 0.5f)
            {
                movePositionOfRedPoint.transform.localScale += smallerSphereScale * Time.deltaTime;
            }
            tpTime = 4f;
        }

    }
}
