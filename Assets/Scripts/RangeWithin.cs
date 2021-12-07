using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangeWithin : MonoBehaviour
{
    public GameObject player;
    public GameObject doorLandingPoint;
    public GameObject movingObject;
    float distance;
    bool flag = true;
    float doorLandingPointY;

    void Start()
    {
        doorLandingPointY = doorLandingPoint.transform.position.y;
        doorLandingPoint.GetComponentInChildren<MeshRenderer>().enabled = true;
    }

    void Update()
    {
        distance = Vector3.Distance(player.transform.position, doorLandingPoint.transform.position);

        if(distance < 6.5f)
        {
            if(flag == true)
            {
                movingObject.transform.position = new Vector3(doorLandingPoint.transform.position.x, 1000, doorLandingPoint.transform.position.z);
                flag = false;
            }
            if(movingObject.transform.position.y > (doorLandingPointY + 16.75f))
            {
                movingObject.transform.position += new Vector3(0, -400 * Time.deltaTime, 0);
            }
            else if(movingObject.transform.position.y <= (doorLandingPointY + 16.75f) && movingObject.transform.position.y > doorLandingPointY)
            {
                movingObject.transform.position += new Vector3(0, -5 * Time.deltaTime, 0);
                doorLandingPoint.GetComponentInChildren<MeshRenderer>().enabled = false;
            }
            else if(movingObject.transform.position.y <= doorLandingPointY)
            {
                movingObject.transform.position += new Vector3(0, 0, 0);
            }
        }
        else if(distance >= 6.5f)
        {
            flag = true;
            doorLandingPoint.GetComponentInChildren<MeshRenderer>().enabled = true;
            movingObject.transform.position = new Vector3(doorLandingPoint.transform.position.x, 1000, doorLandingPoint.transform.position.z);
            movingObject.transform.position = new Vector3(0, -300, 200);
        }
    }
}
