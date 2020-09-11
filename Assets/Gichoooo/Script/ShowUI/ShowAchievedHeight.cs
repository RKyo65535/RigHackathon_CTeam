using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ShowAchievedHeight : MonoBehaviour
{

    Transform TF;
    Vector3 firstPos;
    [SerializeField] GameObject player;
    [SerializeField] int StartHeight;
    [SerializeField] int GoalHeight;


    private void Awake()
    {
        TF = GetComponent<Transform>();
        firstPos = TF.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        float achievedHeight;
        achievedHeight = ((player.transform.position.y - StartHeight)*3/(GoalHeight - StartHeight));

        TF.localPosition = firstPos + new Vector3(0, achievedHeight, 0);

    }
}
