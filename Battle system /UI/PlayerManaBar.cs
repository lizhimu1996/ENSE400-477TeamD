using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManaBar : MonoBehaviour
{

    public PlayerMana playerMana;
    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        slider.maxValue = playerMana.mana;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = playerMana.mana;
    }
}
