using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorButton : MonoBehaviour
{
    [Header("Color Values")]
    public float redAmt;
    public float greenAmt;
    public float blueAmt;
    [Header("Color Sliders")]
    public Slider greenSlider;
    public Slider redSlider;
    public Slider blueSlider;

    private void Awake()
    {
        colorImage = GetComponent<Image>();
        redAmt = colorImage.color.r;
        greenAmt = colorImage.color.g;
        blueAmt = colorImage.color.b;
    }

    public void SetSliderValuesToImageColor()
    {
        redSlider.value = redAmt;
        greenSlider.value = greenAmt;
        blueSlider.value = blueAmt;

        SelectHairColor.redAmt = redAmt;
        SelectHairColor.greenAmt = greenAmt;
        SelectHairColor.blueAmt = blueAmt;

        SelectHairColor.SetHairColor();
    }
}
