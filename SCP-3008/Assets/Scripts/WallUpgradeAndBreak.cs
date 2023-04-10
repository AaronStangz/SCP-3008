using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallUpgradeAndBreak : MonoBehaviour
{
    HandBook metalCount;
    HandBook woodCount;
    HandBook clothCount;
    HandBook paperCount;
    HandBook nailCount;

    public GameObject upgradedPrefab;
    public GameObject oldPrefab;

    public float countName1;
    public float countNub1;
    public float countName2;
    public float countNub2;

    GameObject player;

    void Start()
    {
        player = GameObject.Find("Player");
        metalCount = player.GetComponent<HandBook>();
        woodCount = player.GetComponent<HandBook>();
        clothCount = player.GetComponent<HandBook>();
        paperCount = player.GetComponent<HandBook>();
        nailCount = player.GetComponent<HandBook>();
    }

    void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.U))
            {
                Destroy(oldPrefab);
                Instantiate(upgradedPrefab, transform.position, transform.rotation);

                if ( countName1 > countNub1 && countName2 > countNub2)
                {
                    countName1 -= countNub1;
                    countName2 -= countNub2;
                    Destroy(oldPrefab);
                    Instantiate(upgradedPrefab);

                }
            }
            if (Input.GetKeyDown(KeyCode.X))
            {
                Destroy(oldPrefab);
            }
        }
    }

}
