using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorButton : MonoBehaviour
{
    public SelectHairColor selectHairColor;
    [Header("Color Values")]
    public float redAmt;
    public float greenAmt;
    public float blueAmt;
    [Header("Color Sliders")]
    public Slider greenSlider;
    public Slider redSlider;
    public Slider blueSlider;

    public Image colorImage;

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

        selectHairColor.redAmt = redAmt;
        selectHairColor.greenAmt = greenAmt;
        selectHairColor.blueAmt = blueAmt;

        selectHairColor.SetHairColor();
    }
}
