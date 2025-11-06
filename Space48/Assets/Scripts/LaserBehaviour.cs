
using UnityEngine;

public class LaserBehaviour : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 500;

    void Update()
    {
        transform.position = transform.position + transform.forward * moveSpeed * Time.deltaTime;
    }
}
