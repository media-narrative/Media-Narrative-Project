using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectHairColor : MonoBehaviour
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

    private Color curHairColor;
//grab material from skin mesh renderer for the hair and change the color
    public List<SkinnedMeshRenderer> rendersList = new List<SkinnedMeshRenderer>();
    public void updateSliders()
    {
        greenAmt = green.value;
        redAmt = red.value;
        blueAmt = blue.value;
        SetHairColor();
    }
    public void SetHairColor(){
        curHairColor = new Color (redAmt, greenAmt, blueAmt); //could include alphanum too
    
        for(int i=0; i < rendersList.Count; i++)
        {
            rendersList[i].material.SetColor("_Color",curHairColor);// double check if this arg is right
        }
    }
}
