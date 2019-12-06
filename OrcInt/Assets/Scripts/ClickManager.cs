using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickManager : MonoBehaviour
{
    public GameObject hoveredObject;

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit)) {

            if (Input.GetMouseButtonDown(0)) {
                Debug.Log("MOUSE PRESSED " + hit.collider.gameObject.name);
            }

            GameObject hitObject = hit.collider.gameObject;
            SelectObject(hitObject);
            Debug.Log(hoveredObject);
        }
        else {
            ClearSelection();
        }
    }

    void SelectObject(GameObject obj) {

        if (hoveredObject != null) {
            if(obj == hoveredObject) {
                return;
            }
            ClearSelection();
        }

        hoveredObject = obj;
    }

    void ClearSelection() {
        hoveredObject = null;
    }
}
