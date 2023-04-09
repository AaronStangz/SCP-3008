using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HandBook : MonoBehaviour
{
    [Header("Menus")]
    public GameObject handBook;
    public GameObject puaseMenu;
    public GameObject crafting;

    [Header("Player")]
    public GameObject player;
    [SerializeField]
    private PlayerCam cam;

    [Header("Building")]
    public GameObject wall;
    public GameObject wallText;


    [Header("Crafting")]
    public GameObject paperToWoodText;
    public GameObject netalToNailsText;

    [Header("Mats")]
    public GameObject metalText;
    public int metalCount;
    public GameObject woodText;
    public int woodCount;
    public GameObject clothText;
    public int clothCount;
    public GameObject paperText;
    public int paperCount;
    public GameObject nailText;
    public int nailCount;

    private void Awake()
    {
      //  cam = player.GetComponent<PlayerCam>();

    }

    void Update()
    {
        TextUpdate();

        Escape();

        if (Input.GetKeyDown(KeyCode.H))
        {
            cam.enabled = false;
            Cursor.lockState = CursorLockMode.None;
            TextUpdate();
            player.GetComponent<puase>().isMenuOpen = true;
            handBook.SetActive(true);
        }
    }

    public void MetalToNails()
    {
        if (metalCount > 1)
        {
            Debug.Log("MetalToNails");
            metalCount -= 1;
            nailCount += 2;
        }
    }

    public void Wall()
    {
        if (woodCount > 5 && nailCount > 10)
        {
            Debug.Log("placed");
            Instantiate(wall);
            Time.timeScale = 1f;
            Cursor.lockState = CursorLockMode.Locked;
            woodCount -= 5;
            nailCount -= 10;
            cam.enabled = true;
            player.GetComponent<puase>().isMenuOpen = true;
            handBook.SetActive(false);
        }
    }

    public void PaperToWood()
    {
        if (paperCount > 10)
        {
            Debug.Log("PaperToWood");
            paperCount -= 10;
            woodCount += 1;
        }
    }

    void TextUpdate()
    {
        wallText.GetComponent<TextMeshProUGUI>().text = "( Wood: " + woodCount + " / 5 )" + "( Nails: " + nailCount + " / 10 )";

        netalToNailsText.GetComponent<TextMeshProUGUI>().text = "( Metal: " + metalCount + " / 1 )";
        paperToWoodText.GetComponent<TextMeshProUGUI>().text = "( Paper: " + paperCount + " / 10 )";

        metalText.GetComponent<TextMeshProUGUI>().text = "Metal: " + metalCount;
        woodText.GetComponent<TextMeshProUGUI>().text = "Wood: " + woodCount;
        clothText.GetComponent<TextMeshProUGUI>().text = "Cloth: " + clothCount;
        paperText.GetComponent<TextMeshProUGUI>().text = "Paper: " + paperCount;
        nailText.GetComponent<TextMeshProUGUI>().text = "Nails: " + nailCount;
    }

    void Escape()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            player.GetComponent<puase>().isMenuOpen = false;
            cam.enabled = true;
        }

        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.Locked;
            crafting.SetActive(false);
            handBook.SetActive(false);
        }
    }
}