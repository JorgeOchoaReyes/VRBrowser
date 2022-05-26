using UnityEngine;
using System.Collections;
using TMPro;


public class KeyboardOpen : MonoBehaviour
{
    public string stringToEdit = "Hello World";
    private TouchScreenKeyboard keyboard;
    GameObject text; 

    // Opens native keyboard
    void OnGUI()
    {

        
    }

    public void Update()
    {
        GameObject.Find("Square21").GetComponentInChildren<TextMeshProUGUI>().text = TouchScreenKeyboard.visible ? "True" : "False"; 
    }

     public void Start()
    {

    }
}