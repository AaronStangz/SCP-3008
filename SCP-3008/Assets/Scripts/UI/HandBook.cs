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

    [Header("UI")]
    public GameObject InvUI;

    [Header("Crafting Text")]
    public GameObject paperToWoodText;
    public GameObject netalToNailsText;
    public GameObject scrapMetalToMetalText;
    public GameObject scrapWoodToWoodText;
    public GameObject craftingScrapAxeText;
    public GameObject craftingWoodAxeText;
    public GameObject craftingMetalAxeText;
    public GameObject metalToWireText;

    [Header("InvButtons")]
    public GameObject ScrapAxeButton;
    public GameObject WoodAxeButton;
    public GameObject MetalAxeButton;

    [Header("Items")]
    public GameObject ScrapAxeItem;
    public GameObject WoodAxeItem;
    public GameObject MetalAxeItem;

    [Header("Mats")]
    public int metalCount;
    public int woodCount;
    public int clothCount;
    public int paperCount;
    public int nailCount;
    public int scrapWoodCount;
    public int scrapMatelCount;
    public int matelWireCount;

    public bool HandBookOpen = false;

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
            handBook.SetActive(true);
            HungerThirstHealth.SetActive(false);
            HandBookOpen = true;
        }

        if (HandBookOpen == false)
        {
            cam.enabled = true;
            Cursor.lockState = CursorLockMode.Locked;
            handBook.SetActive(false);
            HungerThirstHealth.SetActive(true);
            HandBookOpen = false;
        }

        if(HandBookOpen == true)
        {
            InvUI.SetActive(false);
        }
        else
        {
            InvUI.SetActive(true);
        }
    }


    public void ScrapWall()
    {
        if (woodCount >= 4 && nailCount >= 30 && scrapWoodCount >= 15)
        {
            Debug.Log("placed");
            Instantiate(scrapwall);
            scrapWoodCount -= 15;
            woodCount -= 4;
            nailCount -= 36;
            HandBookOpen = false;
        }
    }

    public void ScrapDoor()
    {
        if (woodCount >= 4 && nailCount >= 38 && scrapWoodCount >= 19)
        {
            Debug.Log("placed");
            Instantiate(scrapdoor);
            scrapWoodCount -= 19;
            woodCount -= 4;
            nailCount -= 38;
            HandBookOpen = false;
        }
    }

    public void ScrapWindow()
    {
        if (woodCount >= 4 && nailCount >= 46 && scrapWoodCount >= 23)
        {
            Debug.Log("placed");
            Instantiate(scrapwindow);
            scrapWoodCount -= 23;
            woodCount -= 4;
            nailCount -= 46;
            cam.enabled = true;
            HandBookOpen = false;
        }
    }

    public void WoodWall()
    {
        if (woodCount >= 30 && nailCount >= 60)
        {
            Debug.Log("placed");
            Instantiate(woodwall);
            woodCount -= 30;
            nailCount -= 60;
            HandBookOpen = false;
        }
    }

    public void WallDoor()
    {
        if (woodCount >= 10 && nailCount >= 20)
        {
            Debug.Log("placed");
            Instantiate(wooddoor);
            woodCount -= 5;
            nailCount -= 10;
            HandBookOpen = false;
        }
    }

    public void WallWindow()
    {
        if (woodCount >= 46 && nailCount >= 96)
        {
            Debug.Log("placed");
            Instantiate(woodwindow);
            woodCount -= 46;
            nailCount -= 96;
            HandBookOpen = false;
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
    public void ScrapMetalToMetal()
    {
        if (scrapMatelCount >= 4)
        {
            Debug.Log("ScrapMetalToMetal");
            scrapMatelCount -= 4;
            metalCount += 1;
        }
    }

    public void ScrapWoodToWood()
    {
        if (scrapWoodCount >= 4)
        {
            Debug.Log("ScrapMetalToMetal");
            scrapWoodCount -= 4;
            woodCount += 1;
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

    public void MetalToWire()
    {
        if (metalCount >= 1)
        {
            Debug.Log("MetalToWire");
            metalCount -= 1;
            matelWireCount += 5;
        }
    }

    public void CraftScrapAxe()
    {
        if (scrapWoodCount >= 4 && nailCount >= 8)
        {
            Debug.Log("CraftingScrapAxe");
            scrapWoodCount -= 4;
            nailCount -= 8;
            ScrapAxeButton.SetActive(true);
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
        }
    }
    void TextUpdate()
    {
        scrapwallText.GetComponent<TextMeshProUGUI>().text = "( Scrap Wood: " + scrapWoodCount + " / 15 )" + "( Nails: " + nailCount + " / 30 )" + "( Wood: " + woodCount + " / 4 )";
        scrapdoorText.GetComponent<TextMeshProUGUI>().text = "( Scrap Wood: " + scrapWoodCount + " / 19 )" + "( Nails: " + nailCount + " / 38 )" + "( Wood: " + woodCount + " / 4 )";
        scrapwindowText.GetComponent<TextMeshProUGUI>().text = "( Scrap Wood: " + scrapWoodCount + " / 23 )" + "( Nails: " + nailCount + " / 46 )" + "( Wood: " + woodCount + " / 4 )";

        woodwallText.GetComponent<TextMeshProUGUI>().text = "( Wood: " + woodCount + " / 30 )" + "( Nails: " + nailCount + " / 60 )";
        wooddoorText.GetComponent<TextMeshProUGUI>().text = "( Wood: " + woodCount + " / 38 )" + "( Nails: " + nailCount + " / 76 )";
        woodwindowText.GetComponent<TextMeshProUGUI>().text = "( Wood: " + woodCount + " / 46 )" + "( Nails: " + nailCount + " / 96 )";

        netalToNailsText.GetComponent<TextMeshProUGUI>().text = "( Metal: " + metalCount + " / 1 )";
        metalToWireText.GetComponent<TextMeshProUGUI>().text = "( Metal: " + metalCount + " / 1 )";
        paperToWoodText.GetComponent<TextMeshProUGUI>().text = "( Paper: " + paperCount + " / 10 )";
        scrapMetalToMetalText.GetComponent<TextMeshProUGUI>().text = "( Scrap Metal: " + scrapMatelCount + " / 4 )";
        scrapWoodToWoodText.GetComponent<TextMeshProUGUI>().text = "( Scrap Wood: " + scrapWoodCount + " / 4 )";
        craftingScrapAxeText.GetComponent<TextMeshProUGUI>().text = "(Scrap Wood: " + scrapWoodCount + " / 4 )" + "( Nails: " + nailCount + " / 8 )";
        craftingWoodAxeText.GetComponent<TextMeshProUGUI>().text = "( Wood: " + woodCount + " / 4 )" + "( Nails: " + nailCount + " / 8 )";
        craftingMetalAxeText.GetComponent<TextMeshProUGUI>().text = "( Metal: " + metalCount + " / 20 )" + "( Wood: " + woodCount + " / 8 )" + "( Nails: " + nailCount + " / 16 )";
    }

    void Escape()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            cam.enabled = true;
            HungerThirstHealth.SetActive(true);
            Cursor.lockState = CursorLockMode.Locked;
            crafting.SetActive(false);
            handBook.SetActive(false);
            HandBookOpen = false;
        }
    }
    public void ToPage2()
    {
        Page1.SetActive(false);
        Page2.SetActive(true);
    }
    public void ToPage1()
    {
        Page1.SetActive(true);
        Page2.SetActive(false);
    }
}