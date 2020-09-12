using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeCanvas : MonoBehaviour
{
    [SerializeField] GameObject canvas1;
    [SerializeField] GameObject canvas2;


    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(() =>
        {
            if (canvas1.activeSelf)
            {
                canvas1.SetActive(false);
                canvas2.SetActive(true);
            }
            else
            {
                canvas1.SetActive(true);
                canvas2.SetActive(false);
            }
        });
    }


}
