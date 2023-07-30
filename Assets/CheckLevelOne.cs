using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CheckLevelOne : MonoBehaviour
{
    // Start is called before the first frame update
    public bool canChangeScene = false; // Set this in the Inspector or elsewhere in your code

    public void ChangeScene(string sceneName)
    {
        if (canChangeScene)
        {
            SceneManager.LoadScene("ShopStore");
        }
    }
}
