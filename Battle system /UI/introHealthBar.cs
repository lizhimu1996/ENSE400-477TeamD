using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class introHealthBar : MonoBehaviour
{
    public introHealth introHealth;
    public Slider slider;

    void Start()
  	{
  		slider.maxValue = introHealth.health;
  	}

  	// Update is called once per frame
  	void Update()
      {
  		slider.value = introHealth.health;
      }
}
