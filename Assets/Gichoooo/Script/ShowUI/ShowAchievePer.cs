using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ShowAchievePer : MonoBehaviour
{
    Text text;
    Transform TF;
    Vector3 firstPos;
    [SerializeField] GameObject player;
    [SerializeField] int StartHeight;
    [SerializeField] int GoalHeight;



    private void Awake()
    {
        text = GetComponent<Text>();
        TF = GetComponent<Transform>();
        firstPos = TF.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        int achievedHeight;
        achievedHeight = (int)((player.transform.position.y - StartHeight) * 100 / (GoalHeight - StartHeight));
        text.text = "" + achievedHeight;
    }
}
