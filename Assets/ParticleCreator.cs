using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleCreator : MonoBehaviour
{
    public float _speed = 10f;
    public Rigidbody2D _rigidbodyQ;
    public GameObject _particle;
    public float _temps;

    public float _deltatime = 0.5f;
    public float _rayon = 6f;

    // Start is called before the first frame update
    void Start()
    {
        _temps = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float _creation = _temps + _deltatime;
        if (Time.time >= _creation)
        {
            Instantiate(_particle, Random.insideUnitCircle * _rayon, transform.rotation, transform);
            _temps = Time.time;
        }

    }
}
