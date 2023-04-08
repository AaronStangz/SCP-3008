using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puase : MonoBehaviour
{
    public GameObject puaseMenu;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0f;
            puaseMenu.SetActive(true);
        }
        if (Input.GetMouseButton(0))
        {
            Time.timeScale = 1f;
            puaseMenu.SetActive(false);
        }
    }
   
}