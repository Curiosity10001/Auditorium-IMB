using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeAndColor : MonoBehaviour
{
    public Renderer _volumestick1;
    public Renderer _volumestick2;
    public Renderer _volumestick3;
    public Renderer _volumestick4;
    public Renderer _volumestick5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(AudioSource.volume = 0.0f) 
        {
            _volumestick1 = enable.GetComponent(Element0);
        }
    }
}
