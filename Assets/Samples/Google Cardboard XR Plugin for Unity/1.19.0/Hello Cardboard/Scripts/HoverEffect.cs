using UnityEngine;

public class HoverEffect : MonoBehaviour
{
    public float amplitude = 0.5f; // The amount of movement up and down
    public float speed = 1.0f; // The speed at which the GameObject moves

    private float startY; // The initial Y position of the GameObject

    void Start()
    {
        startY = transform.position.y; // Store the initial Y position of the GameObject
    }

    void Update()
    {
        float newY = startY + amplitude * Mathf.Sin(speed * Time.time); // Calculate the new Y position based on the sine wave
        transform.position = new Vector3(transform.position.x, newY, transform.position.z); // Update the position of the GameObject
    }
}
