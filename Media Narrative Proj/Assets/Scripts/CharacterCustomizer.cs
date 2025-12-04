using UnityEngine;

public class CharacterCustomizer : MonoBehaviour
{
    public GameObject[] hairs; // all hair GameObjects
    public GameObject[] faces; // all face GameObjects
    public void ChangeSkinColor(Color newColor)
    {
        CharacterData.Instance.skinColor = newColor;
    }

    public void ChangeHairColor(Color newColor)
    {
        CharacterData.Instance.hairColor = newColor;
    }

    public void SelectHair(int index)
    {
        for (int i = 0; i < hairs.Length; i++)
            hairs[i].SetActive(i == index);

        CharacterData.Instance.hairIndex = index;
    }

    public void SetBald()
    {
        CharacterData.Instance.hairIndex = -1;
    }

    public void SelectFace(int index)
    {
        for (int i = 0; i < faces.Length; i++)
            faces[i].SetActive(i == index);

        CharacterData.Instance.faceIndex = index;
    }



}
