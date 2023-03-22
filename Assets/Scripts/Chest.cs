using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Chest : MonoBehaviour
{

    public int RequiredNumberOfKeys;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Player P = collision.gameObject.GetComponent<Player>();

            if (P.KeyCount >= RequiredNumberOfKeys)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
