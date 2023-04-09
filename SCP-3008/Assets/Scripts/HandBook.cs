using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HandBook : MonoBehaviour
{
    public GameObject handBook;
    public GameObject puaseMenu;
    public GameObject metalText;
    public int metalCount;
    public GameObject woodText;
    public int woodCount;
    public GameObject clothText;
    public int clothCount;

    void Open()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            puaseMenu.SetActive(false);
            handBook.SetActive(true);
            Time.timeScale = 0f;
            Cursor.lockState = CursorLockMode.None;
            metalText.GetComponent<TextMeshProUGUI>().text = "( " + metalCount + " )";
            woodText.GetComponent<TextMeshProUGUI>().text = "( " + woodCount + " )";
            clothText.GetComponent<TextMeshProUGUI>().text = "( " + clothCount + " )";

        }
    }
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 1f;
            handBook.SetActive(false);
            puaseMenu.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
