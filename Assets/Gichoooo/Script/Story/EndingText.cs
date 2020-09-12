using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class EndingText : MonoBehaviour
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
            "すべて失敗に終わった、そんな火山があった。\n" +
            "そんな延々と火を噴き続ける火山の探索に初めて成功した。\n\n" +
            "噴火を繰り返し、岩や溶岩が飛び散るため、\n" +
            "無人探査は失敗を繰り返していたと思われていた。\n" +
            "しかし、今回の探索でわかったことがある。\n" +
            "ある機械はデータの送信をジャミングされ、\n" +
            "ある機械は電気回路が破損し、\n" +
            "ある機械は記憶装置が破壊され、\n" +
            "ある機械は移動不能となっていた。\n" +
            "いずれも不可解なものであった。\n" +
            "しかし、それも解明されるかもしれない。\n" +
            "山頂にあった未知の構造の金属。\n" +
            "これが特殊な力場を発生させ、\n" +
            "機械をダメにしていたようだ。\n" +
            "ただでさえ無謀な挑戦だったが、一人の科学者により\n" +
            "謎が一つ解明へと向かうのであった。\n";
        rectTransform = GetComponent<RectTransform>();
        text = GetComponent<Text>();
        text.text = BreakString(endText);
    }

    private void FixedUpdate()
    {
        if (++time < endScllol)
        {
            rectTransform.position += new Vector3(0, 0.6f, 0);
        }
        if (time > endcount)
        {
            SceneManager.LoadScene("Title");
        }
    }

    string BreakString( string t)
    {
        string newString="";
        for(int i = 0;i< t.Length; i++)
        {
            if (t[i] == '\n')
            {
                newString += '\n';
                continue;
            }
            float rand = Random.value * 20;

            if (rand < NumOfMachine.GetNum())
            {
                newString += t[i];
            }
            else if(rand < 5)
            {
                newString += '◆';
            }
            else if (rand < 10)
            {
                newString += '無';
            }
            else if (rand < 15)
            {
                newString += '〇';
            }
            else if (rand < 17)
            {
                newString += '×';
            }
            else
            {
                newString += '■';
            }
        }

        return newString;
    }



}
