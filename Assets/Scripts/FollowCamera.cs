using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject thingToFollow;
    private Vector3 offset = new Vector3(0, 0, -10);
    //This Camera position should be same as Car position
    void LateUpdate()
    {
        transform.position = thingToFollow.transform.position + offset;
    }
}
    