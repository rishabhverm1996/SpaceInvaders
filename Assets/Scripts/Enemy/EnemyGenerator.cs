using SpaceInvader.Helper;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace SpaceInvader.Enemy
{
    public class EnemyGenerator : MonoBehaviour
    {
        [SerializeField]
        private Transform m_Parent;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void InstantiateEnemy(int cellId)
        {
            GameObject l_Enemy = Instantiate(Resources.Load("EnemyRed")) as GameObject;

            Debug.LogError(l_Enemy);

            Debug.LogError(GameDataContainer.CellsList[0].xPosition);

            Cells l_CellData = GameDataContainer.CellsList.Single(x => x.id == cellId);

            Debug.LogError("id :: " + l_CellData.id);

            l_Enemy.transform.localPosition = new Vector2(l_CellData.xPosition, l_CellData.yPosition);
            l_Enemy.transform.SetParent(m_Parent, false);
        }
    }
}