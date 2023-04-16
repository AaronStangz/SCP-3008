using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    HandBook metalCount;
    HandBook woodCount;
    HandBook clothCount;
    HandBook paperCount;
    HandBook nailCount;
    HandBook scrapWoodCount;
    HandBook scrapMatelCount;

    HandBook HandBookOpen;

    [Header("Mat Text")]
    public GameObject MetalText;
    public GameObject WoodText;
    public GameObject ClothText;
    public GameObject PaperText;
    public GameObject NailText;
    public GameObject ScrapWoodText;
    public GameObject ScrapMetalText;

    [Header("Player & Cameras")]
    public GameObject PlayerCam;
    public GameObject InvCam;
    public GameObject Inv;
    public GameObject player;


    [Header("Menu")]
    public GameObject puaseMenu;
    public GameObject crafting;
    public GameObject HungerThirstHealth;

    [Header("Items")]
    public GameObject ScrapAxeItem;
    public GameObject WoodAxeItem;
    public GameObject MetalAxeItem;
    public GameObject woodItem;
    public GameObject metalItem;
    public GameObject paperItem;
    public GameObject clothItem;
    public GameObject nailsItem;
    public GameObject scrapwoodItem;
    public GameObject scrapmetaItem;

    [Header("HoldableItems")]
    public GameObject ScrapAxeItemHoldable;
    public GameObject WoodAxeItemHoldable;
    public GameObject MetalAxeItemHoldable;
    

    public bool InvOpen = false;

    void Start()
    {
        metalCount = player.GetComponent<HandBook>();
        woodCount = player.GetComponent<HandBook>();
        clothCount = player.GetComponent<HandBook>();
        paperCount = player.GetComponent<HandBook>();
        nailCount = player.GetComponent<HandBook>();
        scrapWoodCount = player.GetComponent<HandBook>();
        scrapMatelCount = player.GetComponent<HandBook>();
    }

    void Update()
    {

        Escape();
        TextUpdate();

        if (Input.GetKeyDown(KeyCode.I))
        {
            InvOpen = true;
        }
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            InvOpen = true; 
        }

        if (InvOpen == true)
        {
            ScrapAxeItem.SetActive(false);
            WoodAxeItem.SetActive(false);
            MetalAxeItem.SetActive(false);

            Inv.SetActive(true);
            InvCam.SetActive(true);
            PlayerCam.SetActive(false);
            HungerThirstHealth.SetActive(false);
            Cursor.lockState = CursorLockMode.None;
        }
    }

    void TextUpdate()
    {
        if(metalCount.metalCount >= 1)
        {
            MetalText.SetActive(true);
            metalItem.SetActive(true);
            MetalText.GetComponent<TextMeshProUGUI>().text = "( Metal: " + metalCount.metalCount + " )";
        }
        else
        {
            MetalText.SetActive(false);
            metalItem.SetActive(false);
        }

        if (woodCount.woodCount >= 1)
        {

            WoodText.SetActive(true);
            woodItem.SetActive(true);
            WoodText.GetComponent<TextMeshProUGUI>().text = "( Wood: " + woodCount.woodCount + " )";
        }
        else
        {
            WoodText.SetActive(false);
            woodItem.SetActive(false);
        }

        if (paperCount.paperCount >= 1)
        {

            PaperText.SetActive(true);
            paperItem.SetActive(true);
            PaperText.GetComponent<TextMeshProUGUI>().text = "( Paper: " + paperCount.paperCount + " )";
        }
        else
        {
            PaperText.SetActive(false);
            paperItem.SetActive(false);
        }

        if (nailCount.nailCount >= 1)
        {

            NailText.SetActive(true);
            nailsItem.SetActive(true);
            NailText.GetComponent<TextMeshProUGUI>().text = "( Nails: " + nailCount.nailCount + " )";
        }
        else
        {
            NailText.SetActive(false);
            nailsItem.SetActive(false);
        }

        if (clothCount.clothCount >= 1)
        {

            ClothText.SetActive(true);
            clothItem.SetActive(true);
            ClothText.GetComponent<TextMeshProUGUI>().text = "( Cloth: " + clothCount.clothCount + " )";
        }
        else
        {
            ClothText.SetActive(false);
            clothItem.SetActive(false);
        }

        if (scrapWoodCount.scrapWoodCount >= 1)
        {

            ScrapWoodText.SetActive(true);
            scrapwoodItem.SetActive(true);
            ScrapWoodText.GetComponent<TextMeshProUGUI>().text = "( Scrap Wood: " + scrapWoodCount.scrapWoodCount + " )";  
        }
        else
        {
            ScrapWoodText.SetActive(false);
            scrapwoodItem.SetActive(false);
        }

        if (scrapMatelCount.scrapMatelCount >= 1)
        {

            ScrapMetalText.SetActive(true);
            scrapmetaItem.SetActive(true);
            ScrapMetalText.GetComponent<TextMeshProUGUI>().text = "( Scrap Matel: " + scrapMatelCount.scrapMatelCount + " )";
        }
        else
        {
            ScrapMetalText.SetActive(false);
            scrapmetaItem.SetActive(false);
        }

    }

    public void ScrapAxeHold() 
    {
        ScrapAxeItemHoldable.SetActive(true);
        WoodAxeItemHoldable.SetActive(false);
        MetalAxeItemHoldable.SetActive(false);
        Escape();
    }
    public void WoodAxeHold()
    {
        ScrapAxeItemHoldable.SetActive(false);
        WoodAxeItemHoldable.SetActive(true);
        MetalAxeItemHoldable.SetActive(false);
        Escape();
    }
    public void MetalAxeHold()
    {
        ScrapAxeItemHoldable.SetActive(false);
        WoodAxeItemHoldable.SetActive(false);
        MetalAxeItemHoldable.SetActive(true);
        Escape();
    }


    void Escape()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && InvOpen == true && HandBookOpen == false)
        {
            Inv.SetActive(false);
            InvCam.SetActive(false);
            PlayerCam.SetActive(true);
            HungerThirstHealth.SetActive(true);
            Cursor.lockState = CursorLockMode.Locked;
            InvOpen = false;
        }
    }
}
