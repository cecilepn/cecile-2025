using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exo : MonoBehaviour
{

    private const string PLAYER_TAG = "Player";
    [SerializeField] Animator m_Animator;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == PLAYER_TAG)
        {
            return;
        }
        Debug.Log("DETECT OOOOOHHH");
        m_Animator.SetBool("isWithinPlayerRange", true);
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag != PLAYER_TAG)
        {
            return;
        }
        Debug.Log("DETECT AAAAHHHH");
        m_Animator.SetBool("isWithinPlayerRange", false);
    }
}