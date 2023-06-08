using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PlayerController : MonoBehaviour
{
    private Animator _animator;
    private static readonly int Vertical = Animator.StringToHash("vertical");
    private static readonly int Horizontal = Animator.StringToHash("horizontal");
    private static readonly int Attack = Animator.StringToHash("onAttack");

    private string[] _attackNames = new[] { "knee", "hook", "elbow" };

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        var verticalInput = Input.GetAxis("Vertical");
        var horizontalInput = Input.GetAxis("Horizontal");
        
        _animator.SetFloat(Vertical, verticalInput);
        _animator.SetFloat(Horizontal, horizontalInput);

        if (Input.GetMouseButtonDown(0))
        {
            _animator.SetTrigger(Attack);
            OnAttack();
        }
    }

    private void OnAttack()
    {
        _animator.SetTrigger(_attackNames[GetIndexOfAttackMove()]);
    }

    private int GetIndexOfAttackMove()
    {
        return Random.Range(0, _attackNames.Length);
    }
    
}
