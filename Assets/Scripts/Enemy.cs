using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private GameObject _KillEffectPrefab;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Bird bird =  collision.collider.GetComponent<Bird>();
        if (bird != null)
        {
            Instantiate(_KillEffectPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
            return;
        }

        Enemy enemy = collision.collider.GetComponent<Enemy>();
        if (enemy != null)
        {
            return;
        }

        if (collision.contacts[0].normal.y < -0.5 )
        {
            Instantiate(_KillEffectPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }

        if (GetComponent<Rigidbody2D>().velocity.magnitude > 1 && collision.gameObject.tag == "Ground") // Check to see if Enemy falls on floor
        {
            Instantiate(_KillEffectPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }

        if (GetComponent<Rigidbody2D>().velocity.magnitude > 1 && collision.gameObject.tag == "Crate") // Check to see if Enemy falls on floor
        {
            Instantiate(_KillEffectPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
