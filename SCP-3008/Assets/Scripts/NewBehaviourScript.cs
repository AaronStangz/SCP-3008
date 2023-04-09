using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject player;
    public GameObject wall;

    public void Wall()
    {
        Debug.Log("placed");
        Instantiate(wall);
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
        player.GetComponent<puase>().isMenuOpen = false;
    }
}
