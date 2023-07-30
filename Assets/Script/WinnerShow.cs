using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinnerShow : MonoBehaviour
{
    public void Winner_Show()
    {
        SceneManager.LoadScene("Winner");
    }
}
