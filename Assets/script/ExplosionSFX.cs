using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionSFX : MonoBehaviour
{
    // Start is called before the first frame update
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
