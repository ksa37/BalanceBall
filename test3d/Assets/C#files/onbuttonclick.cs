using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class onbuttonclick : MonoBehaviour
{
   
    public void Sceneconvert(int index)
    {
        Debug.Log("씬 전환");
        SceneManager.LoadScene(index);
    }

}
