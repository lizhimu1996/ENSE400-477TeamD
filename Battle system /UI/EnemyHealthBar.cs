using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthBar : MonoBehaviour
{
  public EnemyHealth enemyHealth;
	public Slider slider;

	void Start()
	{
		slider.maxValue = enemyHealth.health;
	}

	// Update is called once per frame
	void Update()
    {
		slider.value = enemyHealth.health;
    }
}
