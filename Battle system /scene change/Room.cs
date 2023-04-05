using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Room : MonoBehaviour


{
    public static Room instance;


    public GameObject doorLeft, doorRight, doorUp, doorDown;

    public bool roomLeft, roomRight, roomUp, roomDown;
    // Start is called before the first frame update

    public int stepToStart;

    public int doorNumber;


    void Awake()
    {


      instance = this;
       Debug.Log("empty");



   DontDestroyOnLoad(gameObject);

       }


    void Start()
    {

        doorLeft.SetActive(roomLeft);
        doorRight.SetActive(roomRight);
        doorUp.SetActive(roomUp);
        doorDown.SetActive(roomDown);
    }

    // Update is called once per frame


    void Update()
    {
      if (SceneManager.GetActiveScene().buildIndex < 1)
      {
        Destroy(GameObject.FindWithTag("Room"));

      }
   }





    public void UpdateRoom(float xOffset, float yOffset)
    {
        stepToStart = (int)(Mathf.Abs(transform.position.x / xOffset) + Mathf.Abs(transform.position.y / yOffset));

        if (roomUp)
            doorNumber++;
        if (roomDown)
            doorNumber++;
        if (roomLeft)
            doorNumber++;
        if (roomRight)
            doorNumber++;
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            CameraController.instance.ChangeTarget(transform);

        }
    }


}
