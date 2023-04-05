using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour
{
    SavePlayerPos playerPosData;



    public void QuitGame()
    {
      playerPosData = FindObjectOfType<SavePlayerPos>();
      playerPosData.PlayerPosSave();
      SceneManager.LoadScene("1");
    }

}
