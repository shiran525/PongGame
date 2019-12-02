using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        float startX = Random.Range(0, 2) == 0 ? -1 : 1;
        float startY = Random.Range(0, 2) == 0 ? -1 : 1;

        GetComponent<Rigidbody>().velocity = new Vector3(speed * startX, speed * startY, 0);

    }

    // Update is called once per frame
    void Update()
    {
        if ((GetComponent<Rigidbody>().position.x>13)||( GetComponent<Rigidbody>().position.x< -13)){
            sceneLoader(0);
        }
        speed += 0.1f;
        

    }
    public void sceneLoader(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
