using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointTrigger : MonoBehaviour
{
    [SerializeField] private GameObject teleportTo;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player" && teleportTo != null)
        {
            collision.gameObject.transform.position = teleportTo.transform.position;
        }
    }
}
