using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Character_Boy" || other.gameObject.tag == "Character_Ghost")
        {
            SceneManager.LoadScene(0);
            Debug.Log("Application to menu");
        }
    }
}
