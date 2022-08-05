using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManage : MonoBehaviour
{
    public AudioSource _audioSource;
    public AudioSource _audioSource1;
    public AudioSource _audioSource2;
    public AudioSource _audioSource3;
    public AudioSource _audioSource4;
    public AudioSource _audioSource5;
    public AudioSource _audioSource6;
    public AudioSource _audioSource7;
 

    // Start is called before the first frame update
    void Start()
    {
        _audioSource.Play();
        _audioSource1.Play();
        _audioSource2.Play();
        _audioSource3.Play();
        _audioSource4.Play();
        _audioSource5.Play();
        _audioSource6.Play();
        _audioSource7.Play();
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
