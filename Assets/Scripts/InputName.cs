using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputName : MonoBehaviour
{
    public string input;
    public GameObject inputField;
    public void ReadStringInput()
    {
        input = inputField.GetComponent<Text>().text;
        PlayerPrefs.SetString("Name", input);
    }
}
