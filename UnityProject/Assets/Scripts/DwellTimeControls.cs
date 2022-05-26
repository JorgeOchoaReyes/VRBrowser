using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DwellTimeControls : MonoBehaviour
{
    public Transform rayTransform;
    public OVRInput.Button joyPadClickButton = OVRInput.Button.One;
    public bool pressed;
    public bool released; 
    public Color defaultColor; 
    public GameObject circle;
    public Ray ray;
    public RaycastHit hit;

    // Start is called before the first frame update
    void Start()
    {
        rayTransform = Camera.main.transform;

        circle = GameObject.FindGameObjectWithTag("circle"); 
    }

    // Update is called once per frame
    void Update()
    {
        int layerMask = 1 << 8;
        layerMask = ~layerMask;

        pressed = OVRInput.GetDown(joyPadClickButton);
        released = OVRInput.GetUp(joyPadClickButton);

        if (Physics.Raycast(rayTransform.position, rayTransform.forward, out hit, Mathf.Infinity, layerMask))
        {
            Debug.Log(hit); 
            circle.transform.gameObject.GetComponent<SpriteRenderer>().color = Color.red;
            Debug.Log("Did Hit");
        }

        if (pressed && released) {
            circle.transform.gameObject.GetComponent<SpriteRenderer>().color = Color.green;
        }

        if (pressed) {
            circle.transform.gameObject.GetComponent<SpriteRenderer>().color = Color.green;
        }

        if (released) {
            circle.transform.gameObject.GetComponent<SpriteRenderer>().color = Color.green;
        }
    }
}
