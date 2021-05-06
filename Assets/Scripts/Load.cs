using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Microsoft.MixedReality.Toolkit.UI;

public class Load : MonoBehaviour
{
    public List<GameObject> gameObjects = new List<GameObject>();
    public List<Material> materials = new List<Material>();
    public TextMeshPro TextMeshProGravtity;
    public TextMeshPro TextMeshProBoundingBox;

    private string save = "";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void setSave()
    {
        save = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (GlobalStringName.slot != "" && save == "")
        {
            save = PlayerPrefs.GetString(GlobalStringName.slot);
            LoadGame();
        }
    }

    //find object in prefabs
    public GameObject FindObject(string name)
    {
        GameObject _gameOject = new GameObject();
        for (int i = 0; i < gameObjects.Count; i++)
        {
            if (name.Equals(gameObjects[i].name))
            {
                _gameOject = gameObjects[i];
                return _gameOject;
            }
        }
        return null;
    }

    public void LoadGame()
    {
        setDefault();
        //save = PlayerPrefs.GetString("save");
        //Debug.Log(save);
        


        //List<GameObject> list = new List<GameObject>();

        string[] str = save.Split('=');

        for (int i = 1; i < str.Length; i++)
        {
            string[] str2 = str[i].Split(':');
            GameObject gameObject = new GameObject();
            GameObject clone = new GameObject();

            //set gameObject
            Debug.Log(str2[0]);

            //find object in prefabs
            gameObject = FindObject(str2[0]);

            clone = Instantiate(gameObject, new Vector3(float.Parse(str2[1]), float.Parse(str2[2]), float.Parse(str2[3])), Quaternion.identity);
            clone.name = gameObject.name;
            clone.transform.Rotate(new Vector3(float.Parse(str2[4]), float.Parse(str2[5]), float.Parse(str2[6])));
            clone.transform.localScale = new Vector3(float.Parse(str2[7]), float.Parse(str2[8]), float.Parse(str2[9]));
            

            /*
            //check gravity
            
            if (GlobalVariable.gravity == true)
            {
                clone.AddComponent<Rigidbody>();
                clone.GetComponent<Rigidbody>().useGravity = true;
                clone.GetComponent<Rigidbody>().isKinematic = false;
                StartCoroutine(setRigibody(1f, clone));
            }
            else
            {
                //clone.GetComponent<Rigidbody>().useGravity = false;
                //clone.GetComponent<Rigidbody>().isKinematic = true;
            }

            //check bounding box
            if (GlobalVariable.boundingBox == true)
            {
                clone.GetComponent<BoundingBox>().Active = true;
            }
            else
            {
                clone.GetComponent<BoundingBox>().Active = false;
            }
            */
            
            
            //load material
            string str_material = str2[10];
            Debug.Log("avc" + str_material);

            MeshRenderer meshRenderer = new MeshRenderer();

            //find 
            for (int j = 0; j < materials.Count; j++)
            {
                //Debug.Log(str_material + "=" + materials[j].name);
                if (materials[j].name == str_material)
                {
                    Debug.Log(str_material + "=" + materials[j].name);
                    //meshRenderer.material = materials[j];
                    clone.GetComponent<MeshRenderer>().material = materials[j];
                    break;
                }
            }

            //clone.GetComponent<MeshRenderer>().material = meshRenderer.material;

            //bounding box

            //gravity

            //save
            GlobalVariable.add(clone);
        }
    }

    public void setDefault()
    {
        GlobalVariable.boundingBox = true;
        GlobalVariable.gravity = false;
        TextMeshProBoundingBox.text = "Bounding Box";
        TextMeshProGravtity.text = "No Gravity";
    }

    public IEnumerator setRigibody(float t, GameObject gameObject)
    {
        yield return new WaitForSeconds(t);
        Destroy(gameObject.GetComponent<Rigidbody>());
    }
}
