using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterLoader : MonoBehaviour
{

    [Header("Renderers for Colors")]
    public List<Renderer> skinrendersList = new List<Renderer>();
    //public List<Renderer> hairrendersList = new List<Renderer>();
    // Start is called before the first frame update
    void Start()
    {
        applyCustomization();
    }

    // Update is called once per frame
    public void applyCustomization()
    {
        if (CharacterData.Instance == null)
{
    Debug.LogError("CharacterData.Instance is null! Make sure it exists in the scene.");
    return;
}
        //for the skin colors
        for(int i=0; i < skinrendersList.Count; i++)
        {
            skinrendersList[i].material.color=CharacterData.Instance.skinColor;// double check if this arg is right
        }
    }
}
