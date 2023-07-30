using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelToSelectAOne : MonoBehaviour
{
    public void SelectAOne()
    {
        SceneManager.LoadScene("Play_Level2_1");
    }
}
