using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneToQuit : MonoBehaviour
{
    public void ToQuit()
    {
        SceneManager.LoadScene("Quit_Game");
    }
}
