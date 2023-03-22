using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public Color ActivatedColor;
    bool isActivated;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!isActivated)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                isActivated = true;
                SpriteRenderer renderer = GetComponent<SpriteRenderer>();
                renderer.color = ActivatedColor;
            }
        }
    }
}
