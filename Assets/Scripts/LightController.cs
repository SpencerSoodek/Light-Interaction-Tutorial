using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{

    [SerializeField]
    private Material defaultMaterial;

    [SerializeField]
    private Material selectMaterial;

    
    private MeshRenderer meshRenderer;

    public bool selected;

    private Light light;
    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.material = defaultMaterial;
        selected = false;
        light = GetComponent<Light>();
        light.enabled = false;
    }
 
    // Update is called once per frame
    void Update()
    {

        if (selected)
        {
            meshRenderer.material = selectMaterial;
            if (Input.GetKeyDown(KeyCode.E))
            {
                toggleLight();
            }
        }
        else
        {
            meshRenderer.material = defaultMaterial;
        }
    }

    // Toggle light on or off
    private void toggleLight()
    {
        light.enabled = !light.enabled;
    }
}
