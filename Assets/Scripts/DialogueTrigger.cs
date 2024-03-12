using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public ObjectDialogue objectDialogue;
    public DialogueManager manager;
    public float timer;

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(objectDialogue);
    }

    public void OnTriggerEnter(Collider other)
    {
        StartCoroutine(DialogueRemove());
        if(other.tag == "Character_Boy")
        {
            TriggerDialogue();
        }
    }

    IEnumerator DialogueRemove()
    {
        yield return new WaitForSeconds(timer);
        manager.animator.SetBool("isOpen", false);
    }
}
