using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Follow_Partner : MonoBehaviour
{
    public NavMeshAgent nav;

    //public Camera_Controller camera_Controller;
    //public Transform boy;
    //public Transform ghost;
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        //boy = camera_Controller.character_Boy.transform;
        //ghost = camera_Controller.character_Ghost.transform;
    }

    // Update is called once per frame
    void Update()
    {
        /*if(camera_Controller.target == boy.transform)
        {
            nav.SetDestination(boy.position);
        }

        if (camera_Controller.target == ghost.transform)
        {
            nav.SetDestination(ghost.position);
        }*/
        nav.SetDestination(target.position);

    }
}
