using SpaceInvader.Helper;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiResolution : MonoBehaviour
{
    [SerializeField]
    private GameObject m_world;

    [SerializeField]
    private Camera m_MainCamera;

    private float m_WorldScale;
    // Start is called before the first frame update
    void Awake()
    {
        SetCameraPosition();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SetCameraPosition()
    {
        m_MainCamera.orthographicSize = (Screen.height / (2.0f * Constants.PIXELS_PER_UNIT));
        m_MainCamera.transform.localPosition = new Vector3((Screen.width / (2.0f * Constants.PIXELS_PER_UNIT)), Screen.height / (2.0f * Constants.PIXELS_PER_UNIT), -10.0f);
        m_WorldScale = (Screen.width / Constants.REFERENCE_RESOLUTION_WIDTH);

        m_world.transform.localScale = new Vector3(m_WorldScale, m_WorldScale, 1);
    }
}
