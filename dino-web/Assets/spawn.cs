using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject up;
    public GameObject down;

    public float respawn = 1.0f;
    private Vector2 bounds;
    // Start is called before the first frame update
    void Start()
    {
        bounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(s());
    }
    private void spwanenemy()
    {
        int ran = Random.Range(0, 2);
        Debug.Log(ran);
        if(ran==1)
        {
            GameObject a = Instantiate(up) as GameObject;
            a.transform.position = new Vector2(bounds.x * 2, 2.43f);
        }
        else if(ran==0)
        {
            GameObject a = Instantiate(down) as GameObject;
            a.transform.position = new Vector2(bounds.x * 2, -4.389f);
        }
       
    }
    
    IEnumerator s()
    {
        while(true)
        {
            yield return new WaitForSeconds(respawn);
            spwanenemy();
        }
    }
}
