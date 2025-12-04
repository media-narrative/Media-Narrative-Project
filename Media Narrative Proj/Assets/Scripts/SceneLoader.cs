    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.SceneManagement;

    public class SceneLoader : MonoBehaviour
    {
        

        public void LoadSpecificSceneByIndex(int sceneIndex)
        {
            SceneManager.LoadScene(sceneIndex); // Loads a scene by its index
        }
    }