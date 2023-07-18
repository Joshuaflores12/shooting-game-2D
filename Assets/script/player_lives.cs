using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class player_lives : MonoBehaviour
{
    public static player_lives Instance { get; private set; }
    public int lives = 3;
    public Image[] livesUI;
    public GameObject explosionPrefab;
    public int EnemiesCount;
    // Start is called before the first frame update
    void Awake()
    {
        // If there is an instance, and it's not me, delete myself.

        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }
    private void Start()
    {
        EnemiesCount = 8;
    }
    // Update is called once per frame
    void Update()
    {
        if (EnemiesCount <=0)
        {
            SceneManager.LoadScene("WinScreen");
            
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);

            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            lives -= 1;
            for (int i = 0; i < livesUI.Length; i++)
            {
                if (i < lives)
                {
                    livesUI[i].enabled = true;
                }
                else
                {
                    livesUI[i].enabled = false;
                }
            }
            if (lives <= 0)
            {
                Destroy(gameObject);
                SceneManager.LoadScene("LoseScreen");
            }
        }
    
    if (collision.gameObject.tag == "Enemy Projectile")
        {
            Destroy(collision.gameObject);

    Instantiate(explosionPrefab, transform.position, Quaternion.identity);
    lives -= 1;
            for (int i = 0; i<livesUI.Length; i++)
            {
                if (i<lives)
                {
                    livesUI[i].enabled = true;
                }
                else
                {
                    livesUI[i].enabled = false;
                }
            }
            if (lives <= 0)
            {
                Destroy(gameObject);
                SceneManager.LoadScene("LoseScreen");
            }
        }
    }
}
     

    