using SpaceInvader.Helper;
using SpaceInvader.Storege;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;

namespace SpaceInvader.Enemy
{
    public class EnemyGenerator : MonoBehaviour
    {
        [SerializeField]
        private Transform m_Parent;

        public void EnemySetup()
        {
            EnemyData l_EnemyData = StorageManager.LoadJSON<EnemyData>(EnemyData.ENEMY_DATA_JSON_FILE);

            for (int i = 0; i < l_EnemyData.enemy.Count; i++)
            {
                for (int j = 0; j < l_EnemyData.enemy[i].cellId.Count; j++)
                {
                    string l_Path = Path.Combine(l_EnemyData.prefabPath, l_EnemyData.enemy[0].prefabName);

                    LoadEnemys(l_EnemyData.enemy[i].cellId[j], l_Path);
                }
            }
        }

        public void LoadEnemys(int cellId,string enemyPath)
        {
            GameObject l_Enemy = Instantiate(Resources.Load(enemyPath)) as GameObject;
            Cells l_CellData = GameDataContainer.CellsList.Single(x => x.id == cellId);
            l_Enemy.transform.localPosition = new Vector2(l_CellData.xPosition, l_CellData.yPosition);
            l_Enemy.transform.SetParent(m_Parent, false);
        }
    }
}