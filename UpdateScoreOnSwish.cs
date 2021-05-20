using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class UpdateScoreOnSwish : MonoBehaviour
{
    private Text text;
    public int score=0;
    public GameObject textGO;
    private Font arial;
    void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.name.Equals("Basketball"))
        {
            AudioSource my_Audio = GetComponent<AudioSource>();
            my_Audio.Play();
            score++;
            text = textGO.GetComponent<Text>();
            text.font = arial;
            text.text = "Score:"+score;
            text.fontSize = 14;
            text.alignment = TextAnchor.MiddleCenter;
        }
    }
    // Update is called once per frame
    void Start()
    {
        Font arial1 = (Font)Resources.GetBuiltinResource(typeof(Font), "Arial.ttf");
        arial = arial1;
    }
}
