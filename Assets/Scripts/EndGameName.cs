using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGameName : MonoBehaviour
{
    public Text Name;
    public string playerName;
    void Start()
    {
        playerName = PlayerPrefs.GetString("Name");
        Name.text = "Player Name : " + playerName;
        
    }

   
}
