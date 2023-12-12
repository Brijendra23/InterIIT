using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    private bool isRotating = false;
    private Quaternion originalRotation;
    private Quaternion targetRotation;

    void Start()
    {
        originalRotation = transform.rotation;
        targetRotation = originalRotation;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            isRotating = !isRotating;
            targetRotation = isRotating ? Quaternion.Euler(90, 0, 0) : originalRotation;
        }
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.deltaTime * 5f);
    }
}
