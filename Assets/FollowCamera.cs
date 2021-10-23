using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    //this things should follow car position
    [SerializeField] GameObject thingFollow;
    void LateUpdate()
    {
        transform.position = thingFollow.transform.position + new Vector3(0,0,-10);
    }
}
