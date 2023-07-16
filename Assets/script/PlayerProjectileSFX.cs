using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerProjectileSFX : MonoBehaviour
{

    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
            if (collision.gameObject.tag == "Player") 
            {
            
            audioSource.Play();
            
            }
    }
}
