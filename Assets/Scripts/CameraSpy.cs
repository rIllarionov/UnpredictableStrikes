using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSpy : MonoBehaviour
{
    [SerializeField] private GameObject _targetObject;
    [SerializeField] private Vector3 _cameraOffset;

    private void Update()
    {
        transform.position = _targetObject.transform.position + _cameraOffset;
    }
}
