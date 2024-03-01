using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Camera_Controller : MonoBehaviour
{
    public Transform character_Boy;
    public Transform character_Ghost;
    public Transform target;

    public float smoothSpeed = 0.125f;
    public Vector3 posOffset;
    //public Vector3 rotOffset;

    private void Start()
    {
        target = character_Boy.transform;
    }
    private void FixedUpdate()
    {
        Vector3 desiredPosition = target.position + posOffset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        /*Quaternion desiredRotation = Quaternion.Euler(target.position + rotOffset);
        Quaternion smoothedRotation = Quaternion.Lerp(transform.rotation, desiredRotation, smoothSpeed);
        transform.rotation = smoothedRotation;*/

    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q) && target != character_Ghost)
        {
            target = character_Ghost;
        }
        else if (Input.GetKeyDown(KeyCode.Q) && target != character_Boy)
        {
            target = character_Boy;
        }
    }
}
