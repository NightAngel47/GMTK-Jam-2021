using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunBehaviour : MonoBehaviour
{
    [SerializeField, Tooltip("The bullet prefab.")]
    private GameObject bulletPrefab;

    private void OnCollisionEnter2D(Collision2D other)
    {
        SpawnBullet(other.contacts[0].normal);
    }

    void SpawnBullet(Vector2 fireDir)
    {
        GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
        bullet.GetComponent<Rigidbody2D>().velocity = fireDir; // todo velocity
    }
}
