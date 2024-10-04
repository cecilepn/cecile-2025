using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]

public class Test : MonoBehaviour
{
    [SerializeField] private float m_Threshold;
    Vector3 m_Origin;
    CharacterController m_CharacterController;

    private void Awake()
    {
        m_CharacterController = GetComponent<CharacterController>();
    }
    private void Start()
    {
        m_Origin = transform.position;
    }
    private void Update()
    {
        if (transform.position.y < m_Threshold)
        {
            Debug.Log("LOOOSER");
            Respawn();
        }
    }

    private void Respawn()
    {
        enabled = false;
        transform.position = m_Origin;
        enabled = true;
    }
}
