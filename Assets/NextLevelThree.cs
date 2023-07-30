using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextLevelThree : MonoBehaviour
{
    public void NextLevel3()
    {
        SceneManager.LoadScene("Play_Level3");
    }
}
