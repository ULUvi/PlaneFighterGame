using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtilleryMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed=-2f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;
        if (gameObject.transform.position.x<-8)
        { transform.position = new Vector3(8f,-2.59f,-49.48926f); }
    }
}
