using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectObject : MonoBehaviour
{
    private GameObject changMaterial;

    void Start()
    {
        //gameObject = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void onClick()
    {
        changMaterial = GameObject.Find("Menu3x3");
        changMaterial.GetComponent<ChangeMaterial_Delete>().setGameObject(this.gameObject);

        //highligh

    }
}
