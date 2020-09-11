using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GotoOpening : MonoBehaviour
{
    Button button;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(()=>MovetoOpening());
    }

    void MovetoOpening()
    {
        NumOfMachine.Reset();//触れた数をリセット
        SceneManager.LoadScene("Opening");
    }

}
