using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HandBook : MonoBehaviour
{
    public GameObject handBook;
    public GameObject puaseMenu;
    public GameObject crafting;

    public GameObject player;

    public GameObject metalText;
    public int metalCount;
    public GameObject woodText;
    public int woodCount;
    public GameObject clothText;
    public int clothCount;
    public GameObject paperText;
    public int paperCount;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            Cursor.lockState = CursorLockMode.None;
            handBook.SetActive(true);
            player.GetComponent<puase>().isMenuOpen = true;
            metalText.GetComponent<TextMeshProUGUI>().text = "Metal: " + metalCount;
            woodText.GetComponent<TextMeshProUGUI>().text = "Wood: " + woodCount;
            clothText.GetComponent<TextMeshProUGUI>().text = "Cloth: " + clothCount;
            paperText.GetComponent<TextMeshProUGUI>().text = "Paper: " + paperCount;

        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            player.GetComponent<puase>().isMenuOpen = true;
        }

        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.Locked;
            crafting.SetActive(false);
            handBook.SetActive(false);
        }


    }


}