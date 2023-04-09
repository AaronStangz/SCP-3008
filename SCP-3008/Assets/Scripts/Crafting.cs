
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Crafting: MonoBehaviour
{
    public GameObject handBook;
    public GameObject puaseMenu;
    public GameObject crafting;

    void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.CompareTag("Craft"))
        {
            Open();
        }

    }

    void Open()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            puaseMenu.SetActive(false);
            handBook.SetActive(false);
            crafting.SetActive(true);
            Time.timeScale = 0f;
            Cursor.lockState = CursorLockMode.None;

        }
    }
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 1f;
            handBook.SetActive(false);
            puaseMenu.SetActive(false);
            crafting.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}


