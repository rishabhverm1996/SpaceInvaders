using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SpaceInvader.Helper;
using System.Linq;

public class CellStorage : MonoBehaviour
{
    [SerializeField]
    private GameObject m_Enemy1;


    private List<Cells> m_ListOfCells;
    private int m_IdCounter = 0;

    private void Awake()
    {
        m_ListOfCells = new List<Cells>();
    }

    // Start is called before the first frame update
    void Start()
    {
        //InstantiateCharacter(m_CellId);
        StoreCellsData();
    }

    private void StoreCellsData()
    {
        Vector2 l_CellPosition = Vector2.zero;

        for (int i = 1; i <= Constants.MAX_ROWS; i++)
        {
            for (int j = 1; j <= Constants.MAX_COLUMNS; j++)
            {
                m_IdCounter++;
                l_CellPosition = CalculatePosition(i, j);

                Cells l_CellData = new Cells();
                l_CellData.id = m_IdCounter;
                l_CellData.xPosition = l_CellPosition.x;
                l_CellData.yPosition = l_CellPosition.y;
                GameDataContainer.CellsList.Add(l_CellData);
            }
        }
    }

    private Vector2 CalculatePosition(int row, int column)
    {
        Vector2 l_Position = new Vector2();
        l_Position.x = ((Constants.TILE_PER_SIZE * column) - (Constants.TILE_PER_SIZE / 2f)) / Constants.PIXELS_PER_UNIT;
        l_Position.y = ((Constants.TILE_PER_SIZE * row) - (Constants.TILE_PER_SIZE / 2f)) / Constants.PIXELS_PER_UNIT;

        return l_Position;
    }
}
