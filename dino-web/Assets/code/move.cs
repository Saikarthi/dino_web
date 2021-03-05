using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed=0.1f;
    //private Vector2 bounds;
    private void Start()
    {
        //bounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    void Update()
    {
        this.transform.position += new Vector3(-1, 0, 0) * speed * Time.deltaTime;

    }
    

}
