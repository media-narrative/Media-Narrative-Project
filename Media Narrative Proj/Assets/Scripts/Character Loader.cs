using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterLoader : MonoBehaviour
{

    [Header("Renderers for Colors")]
    public List<Renderer> skinrendersList = new List<Renderer>();
    public List<Renderer> hairrendersList = new List<Renderer>();

    [Header("Game Objects to Switch Out")]
    public List<GameObject> hairList= new List<GameObject>();
    public List<GameObject> faceList= new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        applyCustomization();
    }
    
    // Update is called once per frame
    public void applyCustomization()
    {
        if(CharacterData.Instance.hairIndex== -1)
        {
            for(int i = 0; i < hairList.Count; i++)
            {
                    hairList[i].SetActive(false);
            }
        }
        else
        {
            for(int i = 0; i < hairList.Count; i++)
            {
                if (CharacterData.Instance.hairIndex == i)
                {
                    hairList[i].SetActive(true);
                }
            }
        }
        
        //for the skin colors
        for(int i=0; i < skinrendersList.Count; i++)
        {
            skinrendersList[i].material.color=CharacterData.Instance.skinColor;// double check if this arg is right
        }
        //for the hair colors
        for(int i=0; i < hairrendersList.Count; i++)
        {
            hairrendersList[i].material.color=CharacterData.Instance.hairColor;// double check if this arg is right
        }
        
        for(int i =0; i < faceList.Count; i++)
        {
            faceList[i].SetActive(false);
            if (CharacterData.Instance.faceIndex==i)
            {
                faceList[i].SetActive(true);
            }
        }
    }
}
