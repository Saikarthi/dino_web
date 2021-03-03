using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed=0.1f;



    void Update()
    {
        this.transform.position += new Vector3(1, 0, 0) * speed * Time.deltaTime;
    }
}
