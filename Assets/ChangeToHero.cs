using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeToHero : MonoBehaviour
{
    public void MyHero()
    {
        SceneManager.LoadScene("MyHero");
    }
}
