using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggerswishsound : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        AudioSource my_Audio = GetComponent<AudioSource>();
        my_Audio.Play();
    }
}
