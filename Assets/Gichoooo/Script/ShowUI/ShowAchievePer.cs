using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShowAchievePer : MonoBehaviour
{

    [SerializeField] Sprite[] fonts = new Sprite[10];
    [SerializeField]SpriteRenderer [] sprites = new SpriteRenderer[3];

    [SerializeField] ShowAchievedHeight achievedHeight;


    // Update is called once per frame
    void Update()
    {
        int per = achievedHeight.ShowPercent();
        ChangeValue(per);
    }

    void ChangeValue(int num)
    {
        int n1 = num / 100;
        int n2 = (num %100)/10;
        int n3 = num % 10;

        sprites[2].sprite = fonts[n3];
        sprites[1].sprite = fonts[n2];
        sprites[0].sprite = fonts[n1];

    }




}
