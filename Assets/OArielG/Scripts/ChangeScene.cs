using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public static int tagScene;
    public void loadScene()
    {
        SceneManager.LoadScene(tagScene);
    
    }
}
