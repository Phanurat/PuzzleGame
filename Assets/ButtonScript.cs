using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public GameObject imageToShow;

    public void ShowImage()
    {
        imageToShow.SetActive(true);
    }
}
