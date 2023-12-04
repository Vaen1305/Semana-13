using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveControl : MonoBehaviour
{
    private Animator _compAnimator;
    void Awake()
    {
        _compAnimator = GetComponent<Animator>();  
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Rayo") == true)
        {
            Destroy(this.gameObject, 1);
            _compAnimator.SetTrigger("New Trigger");
        }
    }
}
