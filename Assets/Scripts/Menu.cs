using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Menu : MonoBehaviour
{
    public GameObject UISave;
    public GameObject UILoad;
    public GameObject UIMenu;
    public Load load;

    public void onClickNewRoom()
    {
        for(int i = 0; i < GlobalVariable.list.Count;i++)
        {
            Destroy(GlobalVariable.list[i]);
        }
        GlobalVariable.clean();

    }

    public void onClickSaveRoom()
    {
        UILoad.SetActive(false);
        UISave.SetActive(true);
    }

    public void onClickLoadRoom()
    {
        UISave.SetActive(false);
        UILoad.SetActive(true);
    }
    
    public void onClickBack()
    {
        UILoad.SetActive(false);
        UISave.SetActive(false);
    }

    public void onClickQuit()
    {
        Application.Quit();
    }

    //Load
    public void OnclickSlot1()
    {
        string str = PlayerPrefs.GetString("name1");
        if (str != "")
        {
            onClickNewRoom();
            GlobalStringName.slot = "slot1";
            load.setSave();
        }
    }

    public void OnclickSlot2()
    {
        string str = PlayerPrefs.GetString("name2");
        if (str != "")
        {
            onClickNewRoom();
            GlobalStringName.slot = "slot2";
            load.setSave();
        }
    }

    public void OnclickSlot3()
    {
        string str = PlayerPrefs.GetString("name3");
        if (str != "")
        {
            onClickNewRoom();
            GlobalStringName.slot = "slot3";
            load.setSave();
        }
    }

    public void OnclickSlot4()
    {
        string str = PlayerPrefs.GetString("name4");
        if (str != "")
        {
            onClickNewRoom();
            GlobalStringName.slot = "slot4";
            load.setSave();
        }
    }

    public void OnclickSlot5()
    {
        string str = PlayerPrefs.GetString("name5");
        if (str != "")
        {
            onClickNewRoom();
            GlobalStringName.slot = "slot5";
            load.setSave();
        }
    }

    public void OnclickSlot6()
    {
        string str = PlayerPrefs.GetString("name6");
        if (str != "")
        {
            onClickNewRoom();
            GlobalStringName.slot = "slot6";
            load.setSave();
        }
    }

}
