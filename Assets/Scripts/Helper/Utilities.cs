using System.Collections;
using System.Collections.Generic;

namespace SpaceInvader.Helper
{
    public enum EnemyType
    {
        None = 0,
        Enemy1 = 1,
        Enemy2 = 2,
        Enemy3 = 3,
    }

    public class Utilities
    {

    }

    public class Cells
    {
        public int id;
        public float xPosition;
        public float yPosition;
    }

    public class GameDataContainer
    {
        public static List<Cells> CellsList = new List<Cells>();
    }
}
