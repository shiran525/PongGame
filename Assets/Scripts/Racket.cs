using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket : MonoBehaviour
{
    public bool isRack1;
    public float speed=5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isRack1)
        {
            transform.Translate(0, Input.GetAxis("Vertical") * speed * Time.deltaTime,0);
        }
        else
        {
            transform.Translate(0, Input.GetAxis("Vertical2") * speed * Time.deltaTime, 0);
        }
    }
}
