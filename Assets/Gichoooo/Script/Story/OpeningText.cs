using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OpeningText : MonoBehaviour
{
    string endText;
    Text text;
    RectTransform rectTransform;
    [SerializeField] int endcount;
    [SerializeField] int endScllol;
    int time;

    private void Awake()
    {
        endText = "" +
            "かつで無人探査機で幾度も探査を行ったものの、\n" +
            "すべて失敗に終わった、そんな火山がある。\n" +
            "噴火を繰り返し、岩や溶岩が飛び散るその火山へ\n" +
            "向かう一人の科学者がいた。\n" +
            "さあ、謎を解き明かすべく火山を探索するのだ！\n";
        rectTransform = GetComponent<RectTransform>();
        text = GetComponent<Text>();
        text.text = endText;
    }

    private void FixedUpdate()
    {   
        if(++time < endScllol)
        {
            rectTransform.position += new Vector3(0, 0.6f, 0);
        }
        if(time > endcount)
        {
            SceneManager.LoadScene("DevelopScene");
        }
    }
}
