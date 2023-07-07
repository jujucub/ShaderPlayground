using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    [SerializeField] private Material _material;
    [SerializeField] private float _speed = 0.01f;
    Vector3 _pullVector;

    void Start()
    {
        _pullVector = transform.position;
    }

    void Update()
    {
        _pullVector = Vector3.Lerp(_pullVector, transform.position, _speed);
        _material.SetVector("_PullVector", _pullVector - transform.position);
    }
}
