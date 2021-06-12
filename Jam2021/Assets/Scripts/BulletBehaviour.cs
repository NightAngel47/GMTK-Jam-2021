using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    [SerializeField, Tooltip("Lifetime of the bullet.")]
    private float lifeTime = 5f;
    
    void Start()
    {
        Destroy(gameObject, lifeTime);
    }
}
