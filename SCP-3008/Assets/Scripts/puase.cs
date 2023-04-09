using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puase : MonoBehaviour
{
    public GameObject puaseMenu;

    public bool isMenuOpen = false;
    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isMenuOpen == true)
            {
                isMenuOpen = false;
                puaseMenu.SetActive(false);
            }
            else
            {
              Time.timeScale = 0f;
              puaseMenu.SetActive(true);
              Cursor.lockState = CursorLockMode.None;
              isMenuOpen = true;
            }

        }
        if (Input.GetMouseButton(0))
        {
            Time.timeScale = 1f;
            puaseMenu.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
   
}