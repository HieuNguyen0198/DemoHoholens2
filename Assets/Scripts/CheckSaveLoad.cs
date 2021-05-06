using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CheckSaveLoad : MonoBehaviour
{
    public List<GameObject> gameObjectsSave = new List<GameObject>();
    public List<GameObject> gameObjectsLoad = new List<GameObject>();
    public Color color;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < 6; i++)
        {
            string str = PlayerPrefs.GetString("name" + (i + 1).ToString());
            if (str != "")
            {
                gameObjectsSave[i].transform.GetChild(4).GetChild(0).gameObject.GetComponent<TextMeshPro>().color = color;
                gameObjectsLoad[i].transform.GetChild(4).GetChild(0).gameObject.GetComponent<TextMeshPro>().color = color;
            }
        }
    }
}
