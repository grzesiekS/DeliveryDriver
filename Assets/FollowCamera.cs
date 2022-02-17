using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    private Vector3 cameraOffSetPosition = new Vector3 (0, 0, -10);
    [SerializeField] GameObject thingToFollow;

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = thingToFollow.transform.position + cameraOffSetPosition;
    }
}
