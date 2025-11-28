using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Kai Gidwani
// 11/28/25
// Controls the movement of all objects
// Modified from my IGME202 Project 1 movement script

public class MovementController : MonoBehaviour
{
    [SerializeField] private float speed = 1f; // Set in the inspector
    public float Speed
    {
        get { return speed; }
        set { speed = value; }
    }

    [SerializeField] private Rigidbody rb;

    // Direction object is facing, must be normalized
    [SerializeField] private Vector3 direction = new Vector3(0, 0, 0);
    internal Vector3 Direction
    {
        get { return direction; } // Provide it if needed
        set // Only set a normalized copy!
        {
            direction = value.normalized;
        }
    }



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Set the direction to use x and z instead of x and y
        Vector3 direction3d = new Vector3(direction.x, 0.0f, direction.y);

        // Velocity is direction * speed * deltaTime 
        // (we don’t really even need the tmp variable)
        rb.velocity = direction3d * speed;


        // Rotates the player to the direction they're facing
        if (Direction != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(direction3d, Vector3.up);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
    }
}
