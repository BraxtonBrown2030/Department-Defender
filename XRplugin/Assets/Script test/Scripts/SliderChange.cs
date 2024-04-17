using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderChange : MonoBehaviour
{
    public Slider slider;
    public IntData playerHealth;
    
    public void Start()
    {
        slider.value = playerHealth.value;
    }
    
    public void ChangeSliderValue()
    {
        slider.value = playerHealth.value;
    }
    
    
}
