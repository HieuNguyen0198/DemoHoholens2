using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;

public class Spawner : MonoBehaviour
{
    private GameObject clone;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
 
    }

    public void Spawn(GameObject _gameObject, Transform rb)
    {
        clone = Instantiate(_gameObject, new Vector3(rb.transform.position.x, rb.transform.position.y, rb.transform.position.z), Quaternion.identity);
        clone.name = _gameObject.name;

        
        //check gravity
        
        if(GlobalVariable.gravity == true)
        {
            clone.AddComponent<Rigidbody>();
            clone.GetComponent<Rigidbody>().useGravity = true;
            clone.GetComponent<Rigidbody>().isKinematic = false;
        }
        else
        {
            //clone.GetComponent<Rigidbody>().useGravity = false;
            //clone.GetComponent<Rigidbody>().isKinematic = true;
        }
        
        //check bounding box
        if(GlobalVariable.boundingBox == true)
        {
            clone.GetComponent<BoundingBox>().Active = true;
        }
        else
        {
            clone.GetComponent<BoundingBox>().Active = false;
        }    
    }

    public GameObject getGameObject()
    {
        return clone;
    }
}
