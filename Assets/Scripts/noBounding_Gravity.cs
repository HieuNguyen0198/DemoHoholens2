using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Microsoft.MixedReality.Toolkit.UI;
using Microsoft.MixedReality.Toolkit;

public class noBounding_Gravity : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClickBoundingBox(TextMeshPro textMeshPro)
    {
        int leng = GlobalVariable.list.Count;
        if (textMeshPro.text == "No Bounding Box")
        {
            for (int i = 0; i < leng; i++)
            {
                GlobalVariable.list[i].GetComponent<BoundingBox>().Active = true;
            }
            textMeshPro.text = "Bounding Box";
            GlobalVariable.boundingBox = true;
        }
        else
        {
            for (int i = 0; i < leng; i++)
            {
                GlobalVariable.list[i].GetComponent<BoundingBox>().Active = false;
            }
            textMeshPro.text = "No Bounding Box";
            GlobalVariable.boundingBox = false;
        }
    }

    public void onClickGravity(TextMeshPro textMeshPro)
    {
        int leng = GlobalVariable.list.Count;
        if (textMeshPro.text == "No Gravity")
        {
            for (int i = 0; i < leng; i++)
            {
                GlobalVariable.list[i].AddComponent<Rigidbody>();
                GlobalVariable.list[i].GetComponent<Rigidbody>().useGravity = true;
                GlobalVariable.list[i].GetComponent<Rigidbody>().isKinematic = false;
            }
            textMeshPro.text = "Gravity";
            GlobalVariable.gravity = true;
            StartCoroutine(setRigibody(1f));
        }
        else
        {
            for (int i = 0; i < leng; i++)
            {
                Destroy(GlobalVariable.list[i].GetComponent<Rigidbody>());
                //GlobalVariable.list[i].GetComponent<Rigidbody>().useGravity = false;
                //GlobalVariable.list[i].GetComponent<Rigidbody>().isKinematic = true;
            }
            textMeshPro.text = "No Gravity";
            GlobalVariable.gravity = false;
        }
    }

    public IEnumerator setRigibody(float t)
    {
        yield return new WaitForSeconds(t);
        int leng = GlobalVariable.list.Count;
        for (int i = 0; i < leng; i++)
        {
            Destroy(GlobalVariable.list[i].GetComponent<Rigidbody>());
        }
    }
}
