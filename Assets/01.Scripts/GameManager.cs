using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Sprite[] sprite;
    public Text scenarioText;
    public Image image;
    public GameObject uiCanvas;

    private int count;
    List <string> scripts;


    

    // Start is called before the first frame update
    void Start()
    {
        scripts = new List<string>();
        image = GameObject.Find("Image").GetComponent<Image>();
        uiCanvas = GameObject.Find("UICanvas");
        scenarioText = GameObject.Find("Scenario").GetComponent<Text>();

        //scenarioText.text = "널 팔아버리겠다고 했어";
        image.sprite = sprite[0];
        count = 0;

        SetScript();
    }

    private void SetScript()
    {
        scripts.Add("널 팔아버리겠다고 했어");
        scripts.Add("!!!");
        scripts.Add("도망치자");
        scripts.Add("그랭그랭");


    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKeyDown)
            ++count;

        if(3<=count)
         count = 3;
        

        ChangeUI(count);



    }

    private void ChangeUI(int _count)
    {
        if(3 >_count)
        {
            int arr = _count %2;
            image.sprite = sprite[arr];
            scenarioText.text = scripts[_count];

        }
        else
            uiCanvas.SetActive(false);






    }
}
