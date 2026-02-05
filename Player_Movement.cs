using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    // Speed variable you can adjust in the Unity Inspector
    public float speed = 10f;

    void Update()
    {
        // Get input from WASD or Arrow keys
        // These return a value between -1 and 1
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Create a direction vector based on input
        Vector3 direction = new Vector3(horizontalInput, 0, verticalInput);

        // Move the object 
        // transform.Translate moves the object relative to its local orientation
        // Time.deltaTime ensures movement is smooth and frame-rate independent
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
