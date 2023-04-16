using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BluePrint : MonoBehaviour
{
    public GameObject prefab;

    [SerializeField] private LayerMask layerMask;

    void Start()
    {

    }

    void Update()
    {
        RaycastHit hit;

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 50000.0f, layerMask))
        {
            transform.position = hit.point;
        }

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(prefab, transform.position, transform.rotation);
            Destroy(gameObject);
        }

        if (Input.GetMouseButtonDown(1))
        {
            gameObject.transform.rotation *= Quaternion.Euler(0, 90, 0);
        }
    }
}
