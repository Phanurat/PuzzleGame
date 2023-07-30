using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeToShop : MonoBehaviour
{
    public void ToShop()
    {
        SceneManager.LoadScene("ShopStore");
    }
}
