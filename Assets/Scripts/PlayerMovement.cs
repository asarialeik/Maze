using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float xAxisMovement;
    public float yAxisMovement;
    public float zAxisMovement;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        xAxisMovement = - Input.GetAxis("Horizontal") * Time.deltaTime;
        zAxisMovement = - Input.GetAxis("Vertical") * Time.deltaTime;
        transform.Translate(xAxisMovement, yAxisMovement, zAxisMovement);
    }
}
