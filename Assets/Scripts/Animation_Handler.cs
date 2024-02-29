using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_Handler : MonoBehaviour
{
    public Animator Animator;
    public Character_Controller character_Controller;
    // Start is called before the first frame update
    void Start()
    {
        Animator = GetComponent<Animator>();

        character_Controller = GetComponent<Character_Controller>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Boy_Animations()
    {
        if (character_Controller.playerVelocity.y > 0f)
        {
            Animator.SetBool("isMoving", true);
        }
    }
}
