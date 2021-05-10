using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Microsoft.MixedReality.Toolkit.UI;

public class ChangeMaterial_Delete : MonoBehaviour
{
    private GameObject currentGameObjectSelect;
    private GameObject gameObjectHighlight;
    public TextMeshPro textMesh;
    public Material materialHighlight;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(gameObjectHighlight == null)
        {
            gameObjectHighlight = new GameObject();
            gameObjectHighlight.AddComponent<MeshFilter>();
            gameObjectHighlight.AddComponent<MeshRenderer>();
        }
    }

    public void setGameObject(GameObject _gameObject)
    {
        if(currentGameObjectSelect != _gameObject)
        {
            //select object
            currentGameObjectSelect = _gameObject;
            textMesh.text = currentGameObjectSelect.name;

            //highligh object
            gameObjectHighlight.transform.position = currentGameObjectSelect.transform.position;
            gameObjectHighlight.transform.rotation = currentGameObjectSelect.transform.rotation;
            gameObjectHighlight.transform.SetParent(currentGameObjectSelect.transform);
            
            gameObjectHighlight.GetComponent<MeshFilter>().mesh = currentGameObjectSelect.GetComponent<MeshFilter>().mesh;
            gameObjectHighlight.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);   
            gameObjectHighlight.GetComponent<MeshRenderer>().material = materialHighlight;
        }
    }

    public void OnClickChangeMaterial(MeshRenderer meshRenderer)
    {
        if(currentGameObjectSelect != null)
        {
            currentGameObjectSelect.GetComponent<MeshRenderer>().material = meshRenderer.material;
            Debug.Log("material" + currentGameObjectSelect.name);
            Debug.Log(meshRenderer.material.name);
        }
    }

    public void OnClickDelete()
    {
        //xoa trong list
        int leng = GlobalVariable.list.Count;
        for(int i = leng - 1; i >= 0; i--)
        {
            if(GlobalVariable.list[i] == currentGameObjectSelect)
            {
                GlobalVariable.list.RemoveAt(i);
                break;
            }
        }
        //destroy
        Destroy(currentGameObjectSelect);
    }
}
