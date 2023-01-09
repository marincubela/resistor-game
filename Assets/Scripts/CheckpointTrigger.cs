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
            collision.gameObject.GetComponent<PlayerMovement>().isTransporting = true;
        }

        if (collision.gameObject.name == "Player" && teleportTo == null)
        {
            collision.gameObject.GetComponent<PlayerMovement>().isTransporting = false;
            collision.gameObject.transform.position = transform.position;
            collision.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }
    }
}
