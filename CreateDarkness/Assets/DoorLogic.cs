using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLogic : MonoBehaviour
{
    [SerializeField]
    private Animator _animator;


    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            _animator.SetBool("opendoor", true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            _animator.SetBool("opendoor", false);
        }
    }
}
