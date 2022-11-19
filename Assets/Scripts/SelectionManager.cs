using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionManager : MonoBehaviour
{
    private Transform selection;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (selection != null)
        {
            LightController lightController = selection.GetComponent<LightController>();
            if (lightController != null)
            {
                // Deselect item
                lightController.selected = false;
            }
        }
        
        
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            Transform selection = hit.transform;
            // If ray hits an item and the item has the selectable tag
            if (selection.CompareTag("Selectable"))
            {
                
                var lightController = selection.GetComponent<LightController>();
                if (lightController != null)
                {
                    // If item has a light controller, make the selected component true
                    lightController.selected = true;
                    Debug.Log("YES");
                }

                this.selection = selection;
            }
        }
    }
}