using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public InputField PlayerName;

    private void Start()
    {
        
        if (PlayerPrefs.HasKey("LastPlayer"))
        {
            PlayerName.text = PlayerPrefs.GetString("LastPlayer");          
        }
    }

    public void StartGame()
    {
        DataManager.PlayerInfo.PlayerName = PlayerName.text;
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
