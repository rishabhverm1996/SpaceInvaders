using SpaceInvader.Helper;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace SpaceInvader.Enemy
{
    public class EnemyShip : MonoBehaviour
    {
        public int _cellId;
        public int CellId
        {
            get
            {
                return _cellId;
            }
            set
            {
                _cellId = value;
            }
        }


        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if(Input.GetKeyUp(KeyCode.RightArrow))
            {
                _cellId +=  1;
                Cells l_Cell = GameDataContainer.CellsList.Single(x => x.id == _cellId);
                transform.localPosition = new Vector2(l_Cell.xPosition, l_Cell.yPosition);
            }
            if (Input.GetKeyUp(KeyCode.LeftArrow))
            {
                _cellId -= 1;
                Cells l_Cell = GameDataContainer.CellsList.Single(x => x.id == _cellId);
                transform.localPosition = new Vector2(l_Cell.xPosition, l_Cell.yPosition);
            }
            if (Input.GetKeyUp(KeyCode.UpArrow))
            {
                _cellId += 10;
                Cells l_Cell = GameDataContainer.CellsList.Single(x => x.id == _cellId);
                transform.localPosition = new Vector2(l_Cell.xPosition, l_Cell.yPosition);
            }
            if (Input.GetKeyUp(KeyCode.DownArrow))
            {
                _cellId -= 10;
                Cells l_Cell = GameDataContainer.CellsList.Single(x => x.id == _cellId);
                transform.localPosition = new Vector2(l_Cell.xPosition, l_Cell.yPosition);
            }
        }
    }
}
