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
            var rigidBody = collision.gameObject.GetComponent<Rigidbody2D>();
            rigidBody.AddForce(new Vector2(0, 7));
        }

        if (collision.gameObject.name == "Player" && teleportTo == null)
        {
            collision.gameObject.transform.position = transform.position;
        }
    }
}
