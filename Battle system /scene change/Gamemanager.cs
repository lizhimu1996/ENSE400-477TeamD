using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{


    public static Gamemanager instance = null;

    void Awake()
    {


      if(instance == null)
         {

            instance = this;
             Debug.Log("empty");
         }

         else if (instance != null)
         {
           Destroy(gameObject);
                //gameObject.SetActive(false);
             Debug.Log("not empty");
         }

         DontDestroyOnLoad(gameObject);

       }



       // Update is called once per frame
       void Update()
       {
         if (SceneManager.GetActiveScene().buildIndex < 1)
         {
           Destroy(GameObject.FindWithTag("GameManager"));

         }
      }


    }
