using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingComponent : MonoBehaviour
{

    [SerializeField]
    float rotationYAxis = 90;

    void Update()
    {
        transform.Rotate(0.0f, rotationYAxis * Time.deltaTime, 0f);
    }
}
