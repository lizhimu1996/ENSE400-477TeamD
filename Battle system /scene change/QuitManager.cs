using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class QuitManager : MonoBehaviour
{

  public void QuitGame()
  {

       Application.Quit();
  }

  void OnDestroy()
  {
    Debug.Log("OnDestroy");

  }


  void OnApplicationQuit()
  {
      Debug.Log("Application ending after " + Time.time + " seconds");
  }


}
