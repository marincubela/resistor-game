using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningEffect : MonoBehaviour
{
    private SpriteRenderer sr;
    private PlayerMovement pm;
    [SerializeField] private GameObject player;

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        pm = GetComponentInParent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (pm.isTransporting && Random.Range(0, 10 - pm.transitionForce) == 0)
        {
            var c = sr.color;
            c.a = (1 - c.a / 255) * 255;
            sr.color = c;
        } else
        {
            var c = sr.color;
            c.a = 0;
            sr.color = c;
        }
    }
}
