using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ShowAchievedHeight : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] int StartHeight;
    [SerializeField] int GoalHeight;



    Text text;

    private void Awake()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        int achievedHeight;
        achievedHeight = (int)((player.transform.position.y - StartHeight)*100/(GoalHeight - StartHeight));

        text.text = "到達度 : "+achievedHeight+"%";
    }
}
