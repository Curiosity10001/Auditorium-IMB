using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    public float _deltatime = 0.8f;
    public float _temps;
    // Start is called before the first frame update
    void Start()
    {
        _temps = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float _cycletime = _temps + _deltatime;
        if (Time.time >= _cycletime)
        {
            Destroy(GetComponent<ConstantForce2D>());
        }
    }
}
