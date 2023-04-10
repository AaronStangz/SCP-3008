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

    [Header("Scrap Building")]
    public GameObject scrapwall;
    public GameObject scrapwallText;
    public GameObject scrapdoor;
    public GameObject scrapdoorText;
    public GameObject scrapwindow;
    public GameObject scrapwindowText;

    [Header("Wood Building")]
    public GameObject woodwall;
    public GameObject woodwallText;
    public GameObject wooddoor;
    public GameObject wooddoorText;
    public GameObject woodwindow;
    public GameObject woodwindowText;

    [Header("Pages")]
    public GameObject Page1;
    public GameObject Page2;

    [Header("Crafting")]
    public GameObject paperToWoodText;
    public GameObject netalToNailsText;
    public GameObject craftingAxeText;

    [Header("Items")]
    public GameObject axeButton;
    public GameObject axe;


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


    public void ScrapWall()
    {
        if (woodCount >= 5 && nailCount >= 10)
        {
            Debug.Log("placed");
            Instantiate(scrapwall);
            Time.timeScale = 1f;
            Cursor.lockState = CursorLockMode.Locked;
            woodCount -= 5;
            nailCount -= 10;
            cam.enabled = true;
            player.GetComponent<puase>().isMenuOpen = true;
            handBook.SetActive(false);
        }
    }

    public void ScrapDoor()
    {
        if (woodCount >= 5 && nailCount >= 10)
        {
            Debug.Log("placed");
            Instantiate(scrapdoor);
            Time.timeScale = 1f;
            Cursor.lockState = CursorLockMode.Locked;
            woodCount -= 5;
            nailCount -= 10;
            cam.enabled = true;
            player.GetComponent<puase>().isMenuOpen = true;
            handBook.SetActive(false);
        }
    }

    public void ScrapWindow()
    {
        if (woodCount >= 5 && nailCount >= 10)
        {
            Debug.Log("placed");
            Instantiate(scrapwindow);
            Time.timeScale = 1f;
            Cursor.lockState = CursorLockMode.Locked;
            woodCount -= 5;
            nailCount -= 10;
            cam.enabled = true;
            player.GetComponent<puase>().isMenuOpen = true;
            handBook.SetActive(false);
        }
    }

    public void WoodWall()
    {
        if (woodCount >= 10 && nailCount >= 20)
        {
            Debug.Log("placed");
            Instantiate(woodwall);
            Time.timeScale = 1f;
            Cursor.lockState = CursorLockMode.Locked;
            woodCount -= 5;
            nailCount -= 10;
            cam.enabled = true;
            player.GetComponent<puase>().isMenuOpen = true;
            handBook.SetActive(false);
        }
    }

    public void WallDoor()
    {
        if (woodCount >= 10 && nailCount >= 20)
        {
            Debug.Log("placed");
            Instantiate(wooddoor);
            Time.timeScale = 1f;
            Cursor.lockState = CursorLockMode.Locked;
            woodCount -= 5;
            nailCount -= 10;
            cam.enabled = true;
            player.GetComponent<puase>().isMenuOpen = true;
            handBook.SetActive(false);
        }
    }

    public void WallWindow()
    {
        if (woodCount >= 10 && nailCount >= 20)
        {
            Debug.Log("placed");
            Instantiate(woodwindow);
            Time.timeScale = 1f;
            Cursor.lockState = CursorLockMode.Locked;
            woodCount -= 5;
            nailCount -= 10;
            cam.enabled = true;
            player.GetComponent<puase>().isMenuOpen = true;
            handBook.SetActive(false);
        }
    }
    public void MetalToNails()
    {
        if (metalCount >= 1)
        {
            Debug.Log("MetalToNails");
            metalCount -= 1;
            nailCount += 2;
        }
    }

    public void PaperToWood()
    {
        if (paperCount >= 10)
        {
            Debug.Log("PaperToWood");
            paperCount -= 10;
            woodCount += 1;
        }
    }

    public void CraftAxe()
    {
        if (metalCount >= 5 && woodCount >= 2 && nailCount >= 4)
        {
            Debug.Log("CraftingAxe");
            axeButton.SetActive(true);
            NextPage2();


        }
    }

    public void Axe()
    {
        axe.SetActive(true);
    }

    void TextUpdate()
    {
        scrapwallText.GetComponent<TextMeshProUGUI>().text = "( Wood: " + woodCount + " / 5 )" + "( Nails: " + nailCount + " / 10 )";
        scrapdoorText.GetComponent<TextMeshProUGUI>().text = "( Wood: " + woodCount + " / 5 )" + "( Nails: " + nailCount + " / 10 )";
        scrapwindowText.GetComponent<TextMeshProUGUI>().text = "( Wood: " + woodCount + " / 5 )" + "( Nails: " + nailCount + " / 10 )";
        woodwallText.GetComponent<TextMeshProUGUI>().text = "( Wood: " + woodCount + " / 10 )" + "( Nails: " + nailCount + " / 20 )";
        wooddoorText.GetComponent<TextMeshProUGUI>().text = "( Wood: " + woodCount + " / 10 )" + "( Nails: " + nailCount + " / 20 )";
        woodwindowText.GetComponent<TextMeshProUGUI>().text = "( Wood: " + woodCount + " / 10 )" + "( Nails: " + nailCount + " / 20 )";

        netalToNailsText.GetComponent<TextMeshProUGUI>().text = "( Metal: " + metalCount + " / 1 )";
        paperToWoodText.GetComponent<TextMeshProUGUI>().text = "( Paper: " + paperCount + " / 10 )";
        craftingAxeText.GetComponent<TextMeshProUGUI>().text = "( Metal: " + metalCount + " / 5 )" + "( Wood: " + woodCount + " / 5 )" + "( Nails: " + nailCount + " / 4 )";

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
    public void NextPage1()
    {
        Page1.SetActive(false);
        Page2.SetActive(true);
    }
    public void NextPage2()
    {
        Page1.SetActive(true);
        Page2.SetActive(false);
    }
}