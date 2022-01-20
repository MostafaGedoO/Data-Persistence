using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager PlayerInfo;
    public string PlayerName;
    public int BestScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        if(PlayerInfo != null)
        {
            Destroy(this.gameObject);
            return;
        }       
        PlayerInfo = this;
        DontDestroyOnLoad(gameObject);       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SaveBestScore(int CurrntScore)
    {
        if(CurrntScore > BestScore)
        {
            BestScore = CurrntScore;
            PlayerPrefs.SetInt(PlayerName + "S", BestScore);
            PlayerPrefs.SetString("LastPlayer", PlayerName);          
        }
    }

    public int GetBestScore()
    {
        return PlayerPrefs.GetInt(PlayerName + "S");
    }
}
