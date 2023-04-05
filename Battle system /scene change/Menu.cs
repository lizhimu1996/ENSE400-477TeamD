using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
     //public void NewGame(){


                            // PlayerPrefs.DeleteKey("p_x");
                            // PlayerPrefs.DeleteKey("p_y");
                            // PlayerPrefs.DeleteKey("TimeToLoad");
                          //}

     public void LoadGame(){
          SceneManager.LoadScene("dungeonWithM");

     }


  }
