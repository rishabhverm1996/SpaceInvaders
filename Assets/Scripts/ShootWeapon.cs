using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootWeapon : MonoBehaviour
{
    public Transform m_FirePoint;
    public GameObject m_BulletPrefab;
    List<GameObject> m_Bullets = new List<GameObject>();
    private float m_TimeScale;
    private float m_ShootSpeed = 3f;
    private int m_Index;
    private int m_NumberOfBUllet = 10;
    private void Start()
    {
        Vector3 l_TempPosition;
        l_TempPosition.x = -10f;
        l_TempPosition.y = 0f;
        l_TempPosition.z = 0f;
        for (m_Index = 0; m_Index < m_NumberOfBUllet; m_Index++)
        {
            GameObject l_Bullet = Instantiate(m_BulletPrefab, l_TempPosition, m_FirePoint.rotation);
            m_Bullets.Add(l_Bullet);
        }
        m_Index = 0;
    }
    void Update()
    {
        m_TimeScale += Time.deltaTime * m_ShootSpeed;
        if (m_TimeScale >= 2)
        {
            m_TimeScale = 0;
            m_Bullets[m_Index].SetActive(true);
            m_Bullets[m_Index].transform.position = m_FirePoint.position;
            m_Bullets[m_Index].GetComponent<BulletShoot>().MoveBullet();
            m_Index++;
            if(m_Index == m_NumberOfBUllet)
            {
                m_Index = 0;
            }
           
        }
    }

}
