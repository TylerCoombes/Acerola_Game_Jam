using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow_Partner : MonoBehaviour
{
    public Camera_Controller camera_Controller;
    public Transform Boy;
    public Transform Ghost;

    public Transform partner;

    public Vector3 offset = new Vector3(-2, 0, -2);
    // Start is called before the first frame update
    void Start()
    {
        Boy = camera_Controller.character_Boy.transform;
        Ghost = camera_Controller.character_Ghost.transform;
    }

    // Update is called once per frame
    void Update()
    {
        /*if(camera_Controller.target = Boy)
        {
            partner = Ghost;

            partner.position = Vector3.MoveTowards(partner.position, Boy.position + offset, 10);
        }

        if (camera_Controller.target = Ghost)
        {
            partner = Boy;

            partner.position = Vector3.MoveTowards(partner.position, Ghost.position + offset, 10);
        }*/
    }
}
