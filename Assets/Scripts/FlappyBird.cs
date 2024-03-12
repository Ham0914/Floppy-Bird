using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlappyBird : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float jumpForce = 14f;
    public Vector3 GetPositionPlayer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        rb.velocity = new Vector2(0f, rb.velocity.y);

        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(0f, jumpForce);
        }

        GetPositionPlayer = gameObject.transform.position;

    }
}
