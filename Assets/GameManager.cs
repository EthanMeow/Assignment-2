using Platformer;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public int coinsCounter = 0;
    public Text coinText;

    public PlayerController player;

    void Update()
    {
        coinText.text = coinsCounter.ToString();
 
        if (player.deathState == true)
        {
            // Reload the scene after 3 seconds
            Invoke("ReloadLevel", 0.5f);
        }
    }

    private void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}