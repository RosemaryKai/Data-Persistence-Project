using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.IO;
using TMPro;
using UnityEngine.UI;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;
    public string PlayerName { get; private set; }
    public TMP_InputField playerName;
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void SetName()
    {
        playerName = GameObject.Find("EnterNameTxtBox").GetComponent<TMP_InputField>();

        if (playerName != null && !string.IsNullOrWhiteSpace(playerName.text))
        {
            PlayerName = playerName.text;
        }
        else
        {
            PlayerName = "No Name";
        }

        Debug.Log("Player name set to: " + PlayerName);
    }



}
