using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_Handler : MonoBehaviour
{
    public Animator Animator;
    public Character_Controller character_Controller;
    public Animation anim;
    // Start is called before the first frame update
    void Start()
    {
        Animator = GetComponent<Animator>();

        character_Controller = GetComponent<Character_Controller>();
    }

    // Update is called once per frame
    void Update()
    {
        Boy_Animations();
    }

    void Boy_Animations()
    {
        if (character_Controller.isMoving)
        {
            anim.Play("Run");
            //Animator.SetBool("isMoving", true);
        }
        else anim.Play("Idle");
    }
}
