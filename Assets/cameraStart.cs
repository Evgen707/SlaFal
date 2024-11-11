using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraStart : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

    void Start()
    {
        offset = target.position - transform.position;
    }

    void Update()
    {

        //Движение камеры
        transform.position = target.position - offset;
    }
    void LateUpdate()
    {
        float x = 1; // вычисляете, на что сменить.
        transform.position = new Vector3(x, transform.position.y, transform.position.z);
    }
}
