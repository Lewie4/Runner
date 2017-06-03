using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    [SerializeField] private GameObject m_pug;

    private void Update()
    {
        transform.position = new Vector3(m_pug.transform.position.x, m_pug.transform.position.y, m_pug.transform.position.z - 15);
    }
}
