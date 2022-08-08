using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeAndColor : MonoBehaviour
{
    public MeshRenderer _volumestick1;
    public MeshRenderer _volumestick2;
    public MeshRenderer _volumestick3;
    public MeshRenderer _volumestick4;
    public MeshRenderer _volumestick5;
    public Material _volumeoff;
    public Material _volumeon;
    public AudioSource _audioSource;
   

    // Start is called before the first frame update
    private void Awake()
    {
        _audioSource.volume = 0.0f;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void OnCollisionEnter2D(Collision2D other)
    {
            _audioSource.volume += 0.001f;

            if (_audioSource.volume == 0.0f)
            {
                _volumestick1.material = _volumeoff;
                _volumestick2.material = _volumeoff;
                _volumestick3.material = _volumeoff;
                _volumestick4.material = _volumeoff;
                _volumestick5.material = _volumeoff;
            }
            else if (0.0f < _audioSource.volume && _audioSource.volume <= 0.2f)
            {
                _volumestick1.material = _volumeon;
                _volumestick2.material = _volumeoff;
                _volumestick3.material = _volumeoff;
                _volumestick4.material = _volumeoff;
                _volumestick5.material = _volumeoff;
            }
            else if (0.2f < _audioSource.volume && _audioSource.volume <= 0.4f)
            {
                _volumestick1.material = _volumeon;
                _volumestick2.material = _volumeon;
                _volumestick3.material = _volumeoff;
                _volumestick4.material = _volumeoff;
                _volumestick5.material = _volumeoff;
            }
            else if (0.4f < _audioSource.volume && _audioSource.volume <= 0.6f)
            {
                _volumestick1.material = _volumeon;
                _volumestick2.material = _volumeon;
                _volumestick3.material = _volumeon;
                _volumestick4.material = _volumeoff;
                _volumestick5.material = _volumeoff;
            }
            else if (0.6f < _audioSource.volume && _audioSource.volume <= 0.8f)
            {
                _volumestick1.material = _volumeon;
                _volumestick2.material = _volumeon;
                _volumestick3.material = _volumeon;
                _volumestick4.material = _volumeon;
                _volumestick5.material = _volumeoff;
            }
            else if (0.8f < _audioSource.volume && _audioSource.volume <= 1.0f)
            {
                _volumestick1.material = _volumeon;
                _volumestick2.material = _volumeon;
                _volumestick3.material = _volumeon;
                _volumestick4.material = _volumeon;
                _volumestick5.material = _volumeon;
            }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        _audioSource.volume -= 0.0001f;
    }

}
