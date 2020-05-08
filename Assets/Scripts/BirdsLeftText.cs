using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BirdsLeftText : MonoBehaviour
{
    public Bird birdCounter;
    public Text birdsLeftText;

    // Start is called before the first frame update
    void Start()
    {
        birdsLeftText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        birdsLeftText.text = "Birds Left: " + birdCounter.birdsLeft.ToString();
    }
}
