using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClickCreateButton(GameObject _gameObject)
    {
        Spawner spawner = new Spawner();
        spawner.Spawn(_gameObject, _gameObject.transform);

        //select object when create
        GameObject game = spawner.getGameObject();
        game.GetComponent<SelectObject>().onClick();

        if(GlobalVariable.gravity)
        {
            StartCoroutine(setRigibody(1f, game));
        }

        GlobalVariable.add(game);
    }

    public IEnumerator setRigibody(float t, GameObject gameObject)
    {
        yield return new WaitForSeconds(t);
        Destroy(gameObject.GetComponent<Rigidbody>());
        Debug.Log("Detroy + 1");
    }
}
