using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalObsever : MonoBehaviour
{

    [SerializeField] ShowAchievedHeight height;

    // Update is called once per frame
    void Update()
    {
        if (height.ShowPercent() >= 103)
        {
            SceneManager.LoadScene("Ending");
        }   
    }
}
