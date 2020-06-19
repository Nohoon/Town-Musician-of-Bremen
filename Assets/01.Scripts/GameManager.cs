using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Sprite[] sprite;
    TextMeshProUGUI  scenarioText;
    Image Characters;
    GameObject uiCanvas;

    private int count;
    List <string> scripts;



    

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0f;
        scripts = new List<string>();
        Characters = GameObject.Find("Characters").GetComponent<Image>();
        uiCanvas = GameObject.Find("UICanvas");
        scenarioText = GameObject.Find("Scenario").GetComponent<TextMeshProUGUI>();

        //scenarioText.text = "널 팔아버리겠다고 했어";
        Characters.sprite = sprite[0];
        count = 0;

        SetScript();
    }

    private void SetScript()
    {
        scripts.Add("어느 시골 농장에 늙은 당나귀 한마리가 있었어요.");
        scripts.Add("당나귀는 주인을 위해 이른 아침부터 밤늦게까지 열심히 일했습니다");
        scripts.Add("하지만 당나귀 주인은 늙은 당나귀는 더이상 쓸모없다며 시장에 내다 팔려고 했습니다");
        scripts.Add("이소식을 들은 새 한마리가 급하게 당나귀에게 알려주러 갔습니다" );
        scripts.Add("널 팔아버리겠다고 했어");
        scripts.Add("호에에에엥");
        scripts.Add("도망치자");
        scripts.Add("그랭그랭(아무키나 입력하면 게임이 시작됩니다)");


    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKeyDown)
            ++count;

        if(8<=count)
         count = 8;
        

        ChangeUI();



    }

    private void ChangeUI()
    {

        switch(count)
        {
            default:break;

            case 0:
                Characters.sprite = sprite[0];
                scenarioText.text = scripts[count];

            break;

            case 1:
                Characters.sprite = sprite[0];
                scenarioText.text = scripts[count];
            break;

            case 2:
                Characters.sprite = sprite[0];
                scenarioText.text = scripts[count];
            break;

            case 3:
                Characters.sprite = sprite[0];
                scenarioText.text = scripts[count];
            break;

             case 4:
                Characters.sprite = sprite[1];
                scenarioText.text = scripts[count];
            break;

            case 5:
                Characters.sprite = sprite[2];
                scenarioText.text = scripts[count];
            break;

            case 6:
                Characters.sprite = sprite[1];
                scenarioText.text = scripts[count];
            break;

            case 7:
                Characters.sprite = sprite[2];
                scenarioText.text = scripts[count];
            break;

            case 8: 
            Time.timeScale = 1f;
            uiCanvas.SetActive(false);
            break;

            

        }
    }
}
