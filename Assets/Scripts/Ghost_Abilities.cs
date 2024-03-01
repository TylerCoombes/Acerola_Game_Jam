using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost_Abilities : MonoBehaviour
{
    public CharacterController characterController;
    public float PhaseTimer = 3;
    public bool inputPressed = false;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        PhaseThrough();
    }

    void PhaseThrough()
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

        if (!inputPressed )
        {
            Physics.IgnoreLayerCollision(6, 7, false);
            PhaseTimer = 3;
        }
    }
}
