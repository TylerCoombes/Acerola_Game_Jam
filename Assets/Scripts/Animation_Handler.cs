using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_Handler : MonoBehaviour
{
    public Animator Animator;
    public Character_Controller character_Controller;
    public Animation anim;

    private int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        Animator = GetComponent<Animator>();

        character_Controller = GetComponent<Character_Controller>();

        anim = GetComponent<Animation>();
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
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Character_Ghost" && count == 0)
        {
            anim.Play("Log_Anim");
            Debug.Log("playing");
            count = 1;
        }
    }
}
