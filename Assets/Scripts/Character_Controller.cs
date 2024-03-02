using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMOD.Studio;

public class Character_Controller : MonoBehaviour
{
    private CharacterController controller;
    public Vector3 playerVelocity;
    public bool groundedPlayer;
    private float playerSpeed = 2.0f;
    private float jumpHeight = 0f;
    private float gravityValue = -9.81f;
    public bool isMoving = false;

    public SkinnedMeshRenderer ghost_Mesh;
    public Color color;

    public Camera_Controller camera_Controller;

    private EventInstance playerFootsteps;

    private void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
        color = ghost_Mesh.material.color;

        playerFootsteps = AudioManager.instance.CreateEventInstance(FMODEvents.instance.playerFootsteps);
    }

    void Update()
    {
        Move();
    }

    public void Move()
    {
        if (camera_Controller.target == controller.transform)
        {
            if (camera_Controller.target.tag == "Character_Boy")
            {
                color.a = 0;
                ghost_Mesh.material.color = color;
            }
            else
            {
                color.a = 1;
                ghost_Mesh.material.color = color;
            }

            groundedPlayer = controller.isGrounded;
            if (groundedPlayer && playerVelocity.y < 0)
            {
                playerVelocity.y = 0f;
            }

            Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            controller.Move(move * Time.deltaTime * playerSpeed);

            if (move != Vector3.zero)
            {
                gameObject.transform.forward = move;
                isMoving = true;
            }
            else isMoving = false;

            // Changes the height position of the player..
            if (Input.GetButtonDown("Jump") && groundedPlayer)
            {
                playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
            }

            playerVelocity.y += gravityValue * Time.deltaTime;
            controller.Move(playerVelocity * Time.deltaTime);

            UpdateSound();
        }

    }

    private void UpdateSound()
    {
        if (isMoving)
        {
            PLAYBACK_STATE playbackState;
            playerFootsteps.getPlaybackState(out playbackState);
            if(playbackState.Equals(PLAYBACK_STATE.STOPPED))
            {
                playerFootsteps.start();
            }
        }
        else
        {
            playerFootsteps.stop(STOP_MODE.ALLOWFADEOUT);
        }
    }
}
