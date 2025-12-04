using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterData : MonoBehaviour
{
    public static CharacterData Instance;

    // Add your customization fields here
    public Color hairColor = Color.white;
    public Color skinColor = Color.white;
    public int hairIndex = 0;
    public int faceIndex = 0;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
