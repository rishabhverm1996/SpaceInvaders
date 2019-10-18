using System.Collections.Generic;
using System;
using SpaceInvader.Helper;

namespace SpaceInvader.Enemy
{
    [Serializable]
    public class EnemyData
    {
        public const string ENEMY_DATA_JSON_FILE = "EnemyData";
        public string prefabPath;
        public List<EnemyDataCollector> enemy;
    }

    [Serializable]
    public class EnemyDataCollector
    {
        public EnemyType type;
        public List<int> cellId;
        public int killPoint;
        public string prefabName;
    }
}