using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    const float MINBOUND = -7.5f;
    const float MAXBOUND = 7.5f;
    private void Start()
    {
        
        Vector3 m_InitPositon;
        m_InitPositon.x = 0f;
        m_InitPositon.y = -5f;
        m_InitPositon.z = 0f;
        transform.position = m_InitPositon;
    }
    private void OnMouseDrag()
    {
        Vector3 l_MousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
        Vector3 l_PlayerPosition = Camera.main.ScreenToWorldPoint(l_MousePosition);
        float l_BoundSet = l_PlayerPosition.x;
        l_PlayerPosition.y = -4f;
        l_PlayerPosition.z = 0f;
        if (l_BoundSet >= MAXBOUND)
        {
            l_PlayerPosition.x = MAXBOUND;
        }
        else if (l_BoundSet <= MINBOUND)
        {
            l_PlayerPosition.x = MINBOUND;
        }
        else
        {
            l_PlayerPosition.x = l_BoundSet;
        }
        transform.position = l_PlayerPosition;
    }
}
