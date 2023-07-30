using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RanromLevelSixPageThree : MonoBehaviour
{
    public Button correctButton;
    public Button wrongButton1;
    public Button wrongButton2;

    public Sprite correctButtonSprite;
    public Sprite wrongButtonSprite1;
    public Sprite wrongButtonSprite2;

    public string correctSceneName = "Play_Level6_Page4"; // ชื่อฉากถัดไปหลังกดปุ่มถูก
    public string wrongSceneName = "Play_Level6_Page2";  // ชื่อฉากเดิมหลังกดปุ่มผิด (ถ้าไม่ต้องการเปลี่ยนหน้า ให้เว้นว่างไว้)

    void Start()
    {
        int randomNum = Random.Range(0, 3); 

        if (randomNum == 0)
        {
            correctButton.onClick.AddListener(CorrectButtonClicked);
            correctButton.GetComponent<Image>().sprite = correctButtonSprite;

            wrongButton1.onClick.AddListener(WrongButtonClicked);
            wrongButton1.GetComponent<Image>().sprite = wrongButtonSprite1;

            wrongButton2.onClick.AddListener(WrongButtonClicked);
            wrongButton2.GetComponent<Image>().sprite = wrongButtonSprite2;

        }
        else if (randomNum == 1)
        {
            correctButton.onClick.AddListener(WrongButtonClicked);
            correctButton.GetComponent<Image>().sprite = wrongButtonSprite1;

            wrongButton1.onClick.AddListener(CorrectButtonClicked);
            wrongButton1.GetComponent<Image>().sprite = correctButtonSprite;

            wrongButton2.onClick.AddListener(WrongButtonClicked);
            wrongButton2.GetComponent<Image>().sprite = wrongButtonSprite2;

        }
        else if (randomNum == 2)
        {
            correctButton.onClick.AddListener(WrongButtonClicked);
            correctButton.GetComponent<Image>().sprite = wrongButtonSprite1;

            wrongButton1.onClick.AddListener(WrongButtonClicked);
            wrongButton1.GetComponent<Image>().sprite = wrongButtonSprite2;

            wrongButton2.onClick.AddListener(CorrectButtonClicked);
            wrongButton2.GetComponent<Image>().sprite = correctButtonSprite;

        }
    }

    void CorrectButtonClicked()
    {
        if (correctSceneName != "")
        {
            SceneManager.LoadScene(correctSceneName); // เปลี่ยนหน้าถัดไป
            Debug.Log("Value ==> True!!!!");
        }
    }

    void WrongButtonClicked()
    {
        if (wrongSceneName != "")
        {
            SceneManager.LoadScene(wrongSceneName); // เปลี่ยนหน้าถัดไป
            Debug.Log("Value ==> False!!!!");
        }
    }
}
