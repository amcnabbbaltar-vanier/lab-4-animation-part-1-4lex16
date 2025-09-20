using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimatorController : MonoBehaviour
{
    private Animator _animator;
    private CharacterMovement _movement;
    private Rigidbody _rb;
    
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        _movement = GetComponent<CharacterMovement>();
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        _animator.SetFloat("CharacterSpeed", _rb.velocity.magnitude);
        _animator.SetBool("IsGrounded", _movement.IsGrounded);

        if (Input.GetButtonUp("Fire1"))
        {
            _animator.SetTrigger("doRoll");
        }
    }
}
