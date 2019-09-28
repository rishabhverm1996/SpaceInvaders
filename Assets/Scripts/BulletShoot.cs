using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShoot : MonoBehaviour
{
    public float m_BulletSpeed = 20f;
    public Rigidbody2D rb;
    public void MoveBullet()
    {
        rb.velocity = transform.up * m_BulletSpeed;
    }
    private void OnTriggerEnter2D(Collider2D l_HitInfo)
    {
        EnemyScript enemy = l_HitInfo.GetComponent<EnemyScript>();
        if(enemy != null)
        {
            enemy.TakeDemag(20);
            gameObject.SetActive(false);
        }
    }
}
