using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Enemy
{
    public class EnemyManager : MonoBehaviour
    {
        private EnemyGenerator m_EnemyGenerator;
        private void Awake()
        {
            m_EnemyGenerator = FindObjectOfType<EnemyGenerator>();
        }

        // Start is called before the first frame update
        void Start()
        {
            m_EnemyGenerator.EnemySetup();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}