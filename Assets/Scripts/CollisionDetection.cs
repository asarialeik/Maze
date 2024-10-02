using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    [SerializeField]
    Material defaultMaterial;
    [SerializeField]
    Material collisionMaterial;

    bool collidedWall = false;

    float collidedColorTime = 2.5f;
    void Update()
    {
        if (collidedWall == true)
        {
            collidedColorTime = collidedColorTime - Time.deltaTime;
            if (collidedColorTime < 0.0f)
            {
                gameObject.GetComponent<MeshRenderer>().material = defaultMaterial;
                collidedWall = false;
                collidedColorTime = 2.5f;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gameObject.GetComponent<MeshRenderer>().material = collisionMaterial;
            collidedWall = true;
        }
    }
}
