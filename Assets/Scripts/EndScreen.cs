using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using TMPro;
using UnityEngine;

public class EndScreen : MonoBehaviour
{
    public TMP_Text timeText;
    private void Awake()
    {
        GameManager.Instance.StopMusic();
        GameManager.gameStarted = false;
        timeText.text = "Congratulations, you beat the game in " + ((int) GameManager.gameTimer).ToString(CultureInfo.InvariantCulture) + " seconds!";
    }
}
