using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBackboard : MonoBehaviour
{
    public AudioSource[] sources;
    public AudioSource source;
    public AudioClip source1;
    public AudioClip source2;
    public AudioClip source3;
    // Start is called before the first frame update
    void Start()
    {
        sources = GetComponents<AudioSource>();
        source = sources[0];
        /*
        source1 = sources[0].clip;
        source2 = sources[1].clip;
        source3 = sources[2].clip;
        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Basketball")
        {
            AudioClip my_Audio=null;
            System.Random rand = new System.Random();
            switch (rand.Next(3))
            {
                case 0:
                    my_Audio = source1;
                    break;
                case 1:
                    my_Audio = source2;
                    break;
                    break;
                case 2:
                    my_Audio = source3;
                    break;
                    break;
            }

            source.PlayOneShot(my_Audio, 1.0f);
        }
        
    }
}
