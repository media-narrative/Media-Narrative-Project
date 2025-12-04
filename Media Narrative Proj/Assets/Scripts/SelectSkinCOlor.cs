using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectSkinColor : MonoBehaviour
{
    // Start is called before the first frame update

    

    [Header("Color Values")]
    public float redAmt;
    public float greenAmt;
    public float blueAmt;
    public float alphaAmt;
    [Header("Color Sliders")]
    public Slider green;
    public Slider red;
    public Slider blue;

    private Color curColor;
//grab material from skin mesh renderer for the Skin and change the color
    public List<Renderer> rendersList = new List<Renderer>();
    public void updateSlidersSkin()
    {
        greenAmt = green.value;
        redAmt = red.value;
        blueAmt = blue.value;
        SetSkinColor();
    }
    public void updateSlidersHair()
    {
        greenAmt = green.value;
        redAmt = red.value;
        blueAmt = blue.value;
        SetHairColor();
    }
    public void SetSkinColor(){
        curColor = new Color (redAmt, greenAmt, blueAmt); //could include alphanum too
    
        for(int i=0; i < rendersList.Count; i++)
        {
            rendersList[i].material.color=curColor;// double check if this arg is right
        }

        CharacterData.Instance.skinColor = curColor;
    }
    public void SetHairColor(){
        curColor = new Color (redAmt, greenAmt, blueAmt); //could include alphanum too
    
        for(int i=0; i < rendersList.Count; i++)
        {
            rendersList[i].material.color=curColor;// double check if this arg is right
        }

        CharacterData.Instance.hairColor = curColor;
    }
}
