using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 4.0f;
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        Vector3 playerInput = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
        Vector3 hizeklentisi = playerInput * Time.deltaTime * speed;
        transform.position += hizeklentisi;
    }
}
