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

        //�������� ������
        transform.position = target.position - offset;
    }
    void LateUpdate()
    {
        float x = 1; // ����������, �� ��� �������.
        transform.position = new Vector3(x, transform.position.y, transform.position.z);
    }
}
