using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition3 : MonoBehaviour
{

  public void ModifyGame()
  {
    PlayerPrefs.DeleteKey("p_x");
    PlayerPrefs.DeleteKey("p_x");
    PlayerPrefs.DeleteKey("TimeToLoad");
    PlayerPrefs.DeleteKey("Saved");
    PlayerController2.Gold = 20;
    PlayerController2.HP = 100;
    PlayerController2.MHP = 100;
    PlayerController2.MP = 100;
    PlayerController2.MMP = 100;
    PlayerController2.ATK = 10;
    PlayerController2.AP = 10;
    PlayerController2.DEF = 0;

  //  Destroy(GameObject.FindWithTag("GameManager"));
  //  Destroy(GameObject.FindWithTag("Room"));
  //  Destroy(GameObject.FindWithTag("Wall"));
  
    //SceneManager.MoveGameObjectToScene((GameObject.FindWithTag("GameManager")), SceneManager.GetActiveScene());
    //SceneManager.MoveGameObjectToScene((GameObject.FindWithTag("Untagged")), SceneManager.GetActiveScene());

    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
  }

  public void LoadGame()
   {

       SceneManager.LoadScene("dungeonWithM");
      //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
