using UnityEngine;

public class SimpleMove : MonoBehaviour
{
    public float speed = 15.0f; // Speed of movement

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal") * speed * Time.deltaTime; // Get horizontal input
        float moveY = Input.GetAxis("Vertical") * speed * Time.deltaTime;   // Get vertical input
        float moveZ = 0; // Add this if you want movement in the Z-axis as well

        transform.Translate(moveX, moveY, moveZ); // Move the object
    }
}
