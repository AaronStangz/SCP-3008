
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class Crafting: MonoBehaviour
{
    public GameObject handBook;
    public GameObject puaseMenu;
    public GameObject crafting;
    public GameObject player;

    HandBook metalCount;
    HandBook woodCount;
    HandBook clothCount;
    HandBook paperCount;





    public GameObject wall;
    public GameObject door;
    public GameObject windo;

    void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.CompareTag("Craft"))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                puaseMenu.SetActive(false);
                handBook.SetActive(false);
                crafting.SetActive(true);
                Time.timeScale = 0f;
                Cursor.lockState = CursorLockMode.None;
                player.GetComponent<puase>().isMenuOpen = true;

            }
        }

    }

    public void Wall()
    {
        Debug.Log("placed");
        Instantiate(wall);
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
        player.GetComponent<puase>().isMenuOpen = false;
    }


    void LateUpdate()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 1f;
            crafting.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            player.GetComponent<puase>().isMenuOpen = false;
        }

      //  if (Input.GetKeyDown(KeyCode.Alpha1))
      //  {
      //       Counts();
      //       if (paperCount.paperCount > 1)
    //         {
     //           Debug.Log("placed");
      //          Instantiate(wall);
     //           Time.timeScale = 1f;
    //            Cursor.lockState = CursorLockMode.Locked;
     //           player.GetComponent<puase>().isMenuOpen = false;
      //          paperCount.paperCount -= 10;
     //        }
     //   }
    }

    void Counts()
    {
        player = GameObject.Find("Player");
        metalCount = player.GetComponent<HandBook>();
        woodCount = player.GetComponent<HandBook>();
        clothCount = player.GetComponent<HandBook>();
        paperCount = player.GetComponent<HandBook>();
    }
}


