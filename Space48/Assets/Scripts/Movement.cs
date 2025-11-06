
using UnityEngine;
using System;

public class Movement : MonoBehaviour
{
    [SerializeField] bool getInput;

    public float moveSpeed = 5f;
    public float rotationSpeed = 25f;
    

    void Update()
    {
        Move();
        Rotate();
    }

    void Move()
    {
        if (getInput)
            transform.position = transform.position + transform.forward * moveSpeed * Time.deltaTime * Input.GetAxis("Vertical");
        else
            transform.position = transform.position + transform.forward * moveSpeed * Time.deltaTime;
    }

    void Rotate()
    {
        if (getInput)
            transform.Rotate(transform.up * rotationSpeed * Time.deltaTime * Input.GetAxis("Horizontal"));
    }
}
