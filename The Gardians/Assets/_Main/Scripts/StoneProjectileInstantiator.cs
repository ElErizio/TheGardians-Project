using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneProjectileInstantiator : MonoBehaviour
{
    public float stonePositionOffset;
    public GameObject stonePrefab;
    Rigidbody2D stoneProjectile;
    Collider2D stoneCollider; 
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    void CreateStoneProjectile()
    { 
        stoneProjectile = Instantiate(stonePrefab).GetComponent<Rigidbody2D>();
        stoneCollider = stoneProjectile.GetComponent<Collider2D>();
        stoneCollider.enabled = false;
    }
}
