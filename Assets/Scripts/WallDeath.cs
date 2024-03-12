using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WallDeath : MonoBehaviour
{

    [SerializeField] private float fallX = 0f;
    [SerializeField] private float fallY = 0f;
    [SerializeField] private float grav = 0f;
    private Rigidbody2D rb;
    private Animator anim;
    private GameObject restart;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        restart = GameObject.Find("Canvas/restartText");
        restart.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Death"))
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(GetComponent<FlappyBird>());
        rb.velocity = new Vector2(fallX, fallY);
        rb.gravityScale = grav;
        anim.SetTrigger("death");
        restart.SetActive(true);
    }




}
/*

private Rigidbody2D rb;
private Animator anim;

[SerializeField] private AudioSource deathSound;

private void Start()
{
    anim = GetComponent<Animator>();
    rb = GetComponent<Rigidbody2D>();
}

private void OnCollisionEnter2D(Collision2D collision)
{
    if (collision.gameObject.CompareTag("Trap"))
    {
        Die();
    }
}

private void Die()
{
    deathSound.Play();
    rb.bodyType = RigidbodyType2D.Static;
    anim.SetTrigger("death");
}


private void RestartLevel()
{
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
}

THISSSSSSSSSSSSSS

if (Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }




*/