using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
public float speed = 100; // Speed of the player
public Rigidbody2D rb; // Rigidbody2D component

public void Update()
{
    float x = Input.GetAxis("Horizontal"); // Get the horizontal axis
    float y = Input.GetAxis("Vertical"); // Get the vertical axis

    Vector3 tempVect = new Vector3(x, y, 0); // Create a temporary vector
    tempVect = tempVect.normalized * speed * Time.deltaTime; // Normalize the vector and multiply by speed per second
    rb.MovePosition(rb.transform.position + tempVect); // Move the rigidbody to the temporary vector
}

}
