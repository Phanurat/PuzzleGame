using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToLevel1 : MonoBehaviour
{
    public void BacKLevelFirst()
    {
        SceneManager.LoadScene("Play_Level1");
    }
}
