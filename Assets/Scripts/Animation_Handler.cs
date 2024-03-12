using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_Handler : MonoBehaviour
{
    public Animator Animator;
    public Character_Controller character_Controller;
    public Animation anim;
    public Collider colliderTrigger;

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

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Character_Ghost")
        {
            anim.Play();
            Debug.Log("playing");
            Destroy(colliderTrigger);
        }
    }
}
