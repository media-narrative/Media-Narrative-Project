using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//only use if the faces/ hairstyles are under the same object/ parent
// add this script as a component of the hairstyles or faces game object
//put the parent of the diff types of hairs or faces as the argument
public class DisableAllChildrenofSelectedGameObj : MonoBehaviour
{
    public GameObject parentGameObject;
    public void DisableAllChildren()
    {
        for(int i =0; i<parentGameObject.transform.childCount;i++){
            var child = parentGameObject.transform.GetChild(i).gameObject;
            if(child != null){
                child.SetActive(false);
            }
        }
    }
}
