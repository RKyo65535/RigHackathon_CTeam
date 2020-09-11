using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCreater : MonoBehaviour
{
    [SerializeField] Transform playerTF;
    [SerializeField] GameObject Obstacle;
    [SerializeField] int inicialObjectNum;

    [SerializeField] int intervalFlame;
    [SerializeField] int percent;

    ObjectPool pool;

    int time;





    // Start is called before the first frame update
    void Awake()
    {
        pool = GetComponent<ObjectPool>();
        pool.CreatePool(Obstacle, inicialObjectNum);
    }

    // Update is called once per frame
    void Update()
    {
        if(++time >= intervalFlame)
        {
            if(Random.value*100 < percent)
            {
                GameObject obj = pool.GetObject();
                obj.transform.position = playerTF.position + new Vector3(Random.value * 60 - 30, 60,0);
            }
            time = 0;
        }
    }
}
