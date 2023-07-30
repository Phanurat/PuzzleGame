using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelToSelectATwo : MonoBehaviour
{
    public void SelectATwo()
    {
        SceneManager.LoadScene("Play_Level2");
    }
}
