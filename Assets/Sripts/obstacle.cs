using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward*speed*Time.deltaTime);

        if(transform.position.z<-30)
        {
            Destroy(gameObject);
        }

    }

    private void OnBecameInvisible()
    {
       
    }
}
