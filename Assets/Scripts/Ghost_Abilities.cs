using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost_Abilities : MonoBehaviour
{
    public Camera_Controller cameraController;
    public float PhaseTimer = 3;
    public bool inputPressed = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PhaseThrough();
    }

    void PhaseThrough()
    {
        if(cameraController.target == cameraController.character_Ghost)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                inputPressed = true;
            }

            if (inputPressed)
            {
                PhaseTimer -= Time.deltaTime;


                if (PhaseTimer > 0)
                {
                    Physics.IgnoreLayerCollision(6, 7, true);
                }
                else inputPressed = false;

            }

            if (!inputPressed)
            {
                Physics.IgnoreLayerCollision(6, 7, false);
                PhaseTimer = 3;
            }
        }
    }
}
