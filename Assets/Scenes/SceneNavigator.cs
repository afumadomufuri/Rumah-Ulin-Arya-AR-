using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNavigator : MonoBehaviour
{
    public void AboutScene()
    {
        SceneManager.LoadScene("AboutScene");
    }

    public void CameraScene()
    {
        SceneManager.LoadScene("CameraScene");
    } 
    
    public void InfoScene()
    {
        SceneManager.LoadScene("InfoScene");
    }
}
