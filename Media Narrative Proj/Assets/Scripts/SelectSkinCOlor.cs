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
    public List<Renderer> hairrendersList = new List<Renderer>();
    public List<Renderer> skinrendersList = new List<Renderer>();
    public List<GameObject> faces = new List<GameObject>();

    private Color curColor;
//grab material from skin mesh renderer for the Skin and change the color
    
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
    
        for(int i=0; i < skinrendersList.Count; i++)
        {
            skinrendersList[i].material.color=curColor;// double check if this arg is right
        }

        CharacterData.Instance.skinColor = curColor;
    }
    public void SetHairColor(){
        curColor = new Color (redAmt, greenAmt, blueAmt); //could include alphanum too
    
        for(int i=0; i < hairrendersList.Count; i++)
        {
            hairrendersList[i].material.color=curColor;// double check if this arg is right
        }

        CharacterData.Instance.hairColor = curColor;
    }
    public void setHairstyle(int index)
    {
        if (index < hairrendersList.Count && index > -2)
        {
            CharacterData.Instance.hairIndex = index;
        }
    }

    public void setFace(int index)
    {
        if (index < faces.Count && index > -2)
        {
            CharacterData.Instance.faceIndex = index;
        }
    }
}
