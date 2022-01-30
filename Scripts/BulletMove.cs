using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BulletMove : MonoBehaviour
{
    Vector3 shootDir, lastPosition;
    public Transform targetLook;
    public int damageBullet = 1;
    public float moveSpeed = 100f;
    public GameObject bulletEffect;


    private void Start() 
    {
        lastPosition = transform.position;
    }
    public void Setup(Vector3 shootDir)
    {
        this.shootDir = shootDir;
        Destroy(gameObject, 2f);
    }
    
    
    private void Update()
    {
        transform.Translate(shootDir * moveSpeed * Time.deltaTime);

        RaycastHit hit;

        if(Physics.Linecast(lastPosition, transform.position, out hit))
        {
            if (hit.collider.CompareTag("Enemy"))
            {
                hit.collider.GetComponent<Enemy>().TakeDamage(damageBullet);
            }
            Instantiate(bulletEffect, transform.position, Quaternion.identity);           
            Destroy(gameObject);
        }
        lastPosition = transform.position;

         
    }
    
}

