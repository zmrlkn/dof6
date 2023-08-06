using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{
    RaycastHit hit;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (Physics.Raycast(Camera.main.transform.position, transform.forward, out hit, Mathf.Infinity))
            {
                if(hit.collider.gameObject.tag =="kaya")
                {
                    Destroy(hit.collider.gameObject);
                }
            }
        }
    }
}
