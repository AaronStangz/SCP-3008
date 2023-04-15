using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Inventory : MonoBehaviour
{
    HandBook metalCount;
    HandBook woodCount;
    HandBook clothCount;
    HandBook paperCount;
    HandBook nailCount;

    [Header("Camera")]
    public GameObject PlayerCam;
    public GameObject InvCam;
    public GameObject player;

    [Header("Inv")]
    public GameObject Inv;

    [Header("Menu")]
    public GameObject puaseMenu;
    public GameObject crafting;
    public GameObject HungerThirstHealth;

    [Header("Item In Inv")]
    public GameObject ScrapAxeItem;
    public GameObject WoodAxeItem;
    public GameObject MetalAxeItem;
    public GameObject WoodItem;
    public GameObject MetalItem;
    public GameObject ClothItem;
    public GameObject PaperItem;
    public GameObject NailItem;

    [Header("Text")]
    public GameObject metalText;
    public GameObject woodText;
    public GameObject clothText;
    public GameObject paperText;
    public GameObject nailText;

    public bool InvOpen = false;

    void Start()
    {
        metalCount = player.GetComponent<HandBook>();
        woodCount = player.GetComponent<HandBook>();
        clothCount = player.GetComponent<HandBook>();
        paperCount = player.GetComponent<HandBook>();
        nailCount = player.GetComponent<HandBook>();
    }

    void Update()
    {
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
            GetComponent<PlayerMovement>().enabled = false;
            Inv.SetActive(true);
            InvCam.SetActive(true);
            PlayerCam.SetActive(false);
            HungerThirstHealth.SetActive(false);
            Cursor.lockState = CursorLockMode.None;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Exit();
        }
    }

    public void Exit()
    {
        GetComponent<PlayerMovement>().enabled = true;
        Inv.SetActive(false);
        InvCam.SetActive(false);
        PlayerCam.SetActive(true);
        HungerThirstHealth.SetActive(true);
        InvOpen = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void ScrapAxeHold()
    {
        ScrapAxeItem.SetActive(true);
        WoodAxeItem.SetActive(false);
        MetalAxeItem.SetActive(false);
        Exit();
    }

    public void WoodAxeHold()
    {
        ScrapAxeItem.SetActive(false);
        WoodAxeItem.SetActive(true);
        MetalAxeItem.SetActive(false);
        Exit();
    }

    public void MetalAxeHold()
    {
        ScrapAxeItem.SetActive(false);
        WoodAxeItem.SetActive(false);
        MetalAxeItem.SetActive(true);
        Exit();
    }

    void TextUpdate()
    {
        if (woodCount.woodCount >= 1)
        {
            woodText.SetActive(true);
            WoodItem.SetActive(true);
            woodText.GetComponent<TextMeshProUGUI>().text = "(Wood: " + woodCount.woodCount + " )";
        }
        else 
        { 
            woodText.SetActive(false);
            WoodItem.SetActive(false);
        }
        if (metalCount.metalCount >= 1)
        {
            metalText.SetActive(true);
            MetalItem.SetActive(true);
            metalText.GetComponent<TextMeshProUGUI>().text = "(Metal: " + metalCount.metalCount + " )";
        }
        else 
        { 
            metalText.SetActive(false);
            MetalItem.SetActive(false);
        }
        if (clothCount.clothCount >= 1)
        {
            clothText.SetActive(true);
            ClothItem.SetActive(true);
            clothText.GetComponent<TextMeshProUGUI>().text = "(Cloth: " + clothCount.clothCount + " )";
        }
        else 
        { 
            clothText.SetActive(false);
            ClothItem.SetActive(false);
        }
        if (paperCount.paperCount >= 1)
        {
            paperText.SetActive(true);
            PaperItem.SetActive(true);
            paperText.GetComponent<TextMeshProUGUI>().text = "(Paper: " + paperCount.paperCount + " )";
        }
        else
        { 
            paperText.SetActive(false);
            PaperItem.SetActive(false);
        }
        if (nailCount.nailCount >= 1)
        {
            nailText.SetActive(true);
            NailItem.SetActive(true);
            nailText.GetComponent<TextMeshProUGUI>().text = "(Nails: " + nailCount.nailCount + " )";
        }
        else 
        { 
            nailText.SetActive(false);
            NailItem.SetActive(false);
        }

    }
}
