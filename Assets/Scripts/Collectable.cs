using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Collectable : MonoBehaviour
{

    public int CollectableValue;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Collider2D collider = GetComponent<Collider2D>();
            collider.enabled = false;

         
        }
    }
    public void Remove()
    {
       Destroy(gameObject);
    }

}