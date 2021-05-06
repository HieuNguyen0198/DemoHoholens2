using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeMaterial_Delete : MonoBehaviour
{
    private GameObject currentGameObjectSelect;
    public TextMeshPro textMesh;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void setGameObject(GameObject _gameObject)
    {
        currentGameObjectSelect = _gameObject;
        textMesh.text = currentGameObjectSelect.name;
    }

    public void OnClickChangeMaterial(MeshRenderer meshRenderer)
    {
        currentGameObjectSelect.GetComponent<MeshRenderer>().material = meshRenderer.material;
        Debug.Log("material" + currentGameObjectSelect.name);
        Debug.Log(meshRenderer.material.name);
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
