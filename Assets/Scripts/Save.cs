using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Save : MonoBehaviour
{
    public TextMeshPro text;
   
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    //save with UI
    public void onClickSaveButton1(TextMeshPro btnText)
    {
        //string name Actice scene
        string name = SceneManager.GetActiveScene().name;

        //string save object
        PlayerPrefs.SetString("name1", name);
        PlayerPrefs.SetString("slot1", GlobalVariable.getStringToSave());

        text.text = "1.Room:" + name;
        btnText.text = name;
    }

    public void onClickSaveButton2(TextMeshPro btnText)
    {
        //string name Actice scene
        string name = SceneManager.GetActiveScene().name;

        //string save object
        PlayerPrefs.SetString("name2", name);
        PlayerPrefs.SetString("slot2", GlobalVariable.getStringToSave());

        text.text = "2.Room:" + name;
        btnText.text = name;
    }

    public void onClickSaveButton3(TextMeshPro btnText)
    {
        //string name Actice scene
        string name = SceneManager.GetActiveScene().name;

        //string save object
        PlayerPrefs.SetString("name3", name);
        PlayerPrefs.SetString("slot3", GlobalVariable.getStringToSave());

        text.text = "3.Room:" + name;
        btnText.text = name;
    }

    public void onClickSaveButton4(TextMeshPro btnText)
    {
        //string name Actice scene
        string name = SceneManager.GetActiveScene().name;

        //string save object
        PlayerPrefs.SetString("name4", name);
        PlayerPrefs.SetString("slot4", GlobalVariable.getStringToSave());

        text.text = "4.Room:" + name;
        btnText.text = name;
    }

    public void onClickSaveButton5(TextMeshPro btnText)
    {
        //string name Actice scene
        string name = SceneManager.GetActiveScene().name;

        //string save object
        PlayerPrefs.SetString("name5", name);
        PlayerPrefs.SetString("slot5", GlobalVariable.getStringToSave());

        text.text = "5.Room:" + name;
        btnText.text = name;
    }

    public void onClickSaveButton6(TextMeshPro btnText)
    {
        //string name Actice scene
        string name = SceneManager.GetActiveScene().name;

        //string save object
        PlayerPrefs.SetString("name6", name);
        PlayerPrefs.SetString("slot6", GlobalVariable.getStringToSave());

        text.text = "6.Room:" + name;
        btnText.text = name;
    }
}
