using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderFunction : MonoBehaviour
{
    public TextMeshProUGUI text;
    public Slider slider;
    public void changeText()
    {
        text.text = ""+(int)(slider.value*100);
    }
}
