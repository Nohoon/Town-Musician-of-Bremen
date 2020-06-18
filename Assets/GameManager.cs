using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Sprite[] image;
    public Text scenarioText;

    private string[] speechBubble;
    int count;


    // Start is called before the first frame update
    void Start()
    {
        //image = GameObject.Find("Image").GetComponent<Image>();
       count=0;
       scenarioText = GameObject.Find("Scenario").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scenarioText.text = "널 팔아버리겠다고 했어";
    }
}
