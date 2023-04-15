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
    public GameObject HungerThirstHealth;

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

    [Header("Crafting Text")]
    public GameObject paperToWoodText;
    public GameObject netalToNailsText;
    public GameObject craftingScrapAxeText;
    public GameObject craftingWoodAxeText;
    public GameObject craftingMetalAxeText;

    [Header("InvButtons")]
    public GameObject ScrapAxeButton;
    public GameObject WoodAxeButton;
    public GameObject MetalAxeButton;

    [Header("InvFI")]
    public GameObject ScrapAxeFI;
    public GameObject WoodAxeFI;
    public GameObject MetalAxeFI;

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
            HungerThirstHealth.SetActive(false);
        }
    }


    public void ScrapWall()
    {
        if (woodCount >= 15 && nailCount >= 30)
        {
            Debug.Log("placed");
            Instantiate(scrapwall);
            Time.timeScale = 1f;
            Cursor.lockState = CursorLockMode.Locked;
            woodCount -= 15;
            nailCount -= 36;
            cam.enabled = true;
            player.GetComponent<puase>().isMenuOpen = true;
            handBook.SetActive(false);
            HungerThirstHealth.SetActive(true);
        }
    }

    public void ScrapDoor()
    {
        if (woodCount >= 19 && nailCount >= 38)
        {
            Debug.Log("placed");
            Instantiate(scrapdoor);
            Time.timeScale = 1f;
            Cursor.lockState = CursorLockMode.Locked;
            woodCount -= 19;
            nailCount -= 38;
            cam.enabled = true;
            player.GetComponent<puase>().isMenuOpen = true;
            handBook.SetActive(false);
            HungerThirstHealth.SetActive(true);
        }
    }

    public void ScrapWindow()
    {
        if (woodCount >= 23 && nailCount >= 46)
        {
            Debug.Log("placed");
            Instantiate(scrapwindow);
            Time.timeScale = 1f;
            Cursor.lockState = CursorLockMode.Locked;
            woodCount -= 23;
            nailCount -= 46;
            cam.enabled = true;
            player.GetComponent<puase>().isMenuOpen = true;
            handBook.SetActive(false);
            HungerThirstHealth.SetActive(true);
        }
    }

    public void WoodWall()
    {
        if (woodCount >= 30 && nailCount >= 60)
        {
            Debug.Log("placed");
            Instantiate(woodwall);
            Time.timeScale = 1f;
            Cursor.lockState = CursorLockMode.Locked;
            woodCount -= 30;
            nailCount -= 60;
            cam.enabled = true;
            player.GetComponent<puase>().isMenuOpen = true;
            handBook.SetActive(false);
            HungerThirstHealth.SetActive(true);
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
            HungerThirstHealth.SetActive(true);
        }
    }

    public void WallWindow()
    {
        if (woodCount >= 46 && nailCount >= 96)
        {
            Debug.Log("placed");
            Instantiate(woodwindow);
            Time.timeScale = 1f;
            Cursor.lockState = CursorLockMode.Locked;
            woodCount -= 46;
            nailCount -= 96;
            cam.enabled = true;
            player.GetComponent<puase>().isMenuOpen = true;
            handBook.SetActive(false);
            HungerThirstHealth.SetActive(true);
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

    public void CraftScrapAxe()
    {
        if (woodCount >= 2 && nailCount >= 4)
        {
            Debug.Log("CraftingScrapAxe");
            woodCount -= 2;
            nailCount -= 4;
            ScrapAxeButton.SetActive(true);
            ScrapAxeFI.SetActive(true);

        }
    }
    public void CraftWoodAxe()
    {
        if (woodCount >= 4 && nailCount >= 8)
        {
            Debug.Log("CraftingWoodAxe");
            woodCount -= 4;
            nailCount -= 8;
            WoodAxeButton.SetActive(true);
            WoodAxeFI.SetActive(true);


        }
    }

    public void CraftMetalAxe()
    {
        if (metalCount >= 20 && woodCount >= 8 && nailCount >= 16)
        {
            Debug.Log("CraftingMetalAxe");
            metalCount -= 20;
            woodCount -= 8;
            nailCount -= 16;
            MetalAxeButton.SetActive(true);
            MetalAxeFI.SetActive(true);


        }
    }

    void TextUpdate()
    {
        scrapwallText.GetComponent<TextMeshProUGUI>().text = "( Wood: " + woodCount + " / 15 )" + "( Nails: " + nailCount + " / 30 )";
        scrapdoorText.GetComponent<TextMeshProUGUI>().text = "( Wood: " + woodCount + " / 19 )" + "( Nails: " + nailCount + " / 38 )";
        scrapwindowText.GetComponent<TextMeshProUGUI>().text = "( Wood: " + woodCount + " / 23 )" + "( Nails: " + nailCount + " / 46 )";

        woodwallText.GetComponent<TextMeshProUGUI>().text = "( Wood: " + woodCount + " / 30 )" + "( Nails: " + nailCount + " / 60 )";
        wooddoorText.GetComponent<TextMeshProUGUI>().text = "( Wood: " + woodCount + " / 38 )" + "( Nails: " + nailCount + " / 76 )";
        woodwindowText.GetComponent<TextMeshProUGUI>().text = "( Wood: " + woodCount + " / 46 )" + "( Nails: " + nailCount + " / 96 )";

        netalToNailsText.GetComponent<TextMeshProUGUI>().text = "( Metal: " + metalCount + " / 1 )";
        paperToWoodText.GetComponent<TextMeshProUGUI>().text = "( Paper: " + paperCount + " / 10 )";
        craftingScrapAxeText.GetComponent<TextMeshProUGUI>().text = "( Wood: " + woodCount + " / 2 )" + "( Nails: " + nailCount + " / 4 )";
        craftingWoodAxeText.GetComponent<TextMeshProUGUI>().text = "( Wood: " + woodCount + " / 4 )" + "( Nails: " + nailCount + " / 8 )";
        craftingMetalAxeText.GetComponent<TextMeshProUGUI>().text = "( Metal: " + metalCount + " / 20 )" + "( Wood: " + woodCount + " / 8 )" + "( Nails: " + nailCount + " / 16 )";
    }

    void Escape()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            player.GetComponent<puase>().isMenuOpen = false;
            cam.enabled = true;
            HungerThirstHealth.SetActive(true);
        }

        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.Locked;
            crafting.SetActive(false);
            handBook.SetActive(false);
            HungerThirstHealth.SetActive(true);
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