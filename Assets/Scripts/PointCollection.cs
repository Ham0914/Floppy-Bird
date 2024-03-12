using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointCollection : MonoBehaviour
{
    private int Points = 0;
    [SerializeField] private Text CheckpointsText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Points"))
        {
            Destroy(collision.gameObject);
            Points++;
            CheckpointsText.text = "Checkpoints: " + Points;
        }
    }
}
