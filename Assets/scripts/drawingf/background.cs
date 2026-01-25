using UnityEngine;
using UnityEngine.InputSystem;

public class background : MonoBehaviour
{
    // --- declare variables ---
    Vector3 startPosition;
    public float bgSpeed;
    public float bgLimit;
    public Vector3 lastMousePosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // --- start at flower's position ---
        startPosition = transform.position;
        // --- update mouse position memory ---
        lastMousePosition = Mouse.current.position.ReadValue(); //mouse space (screen or world) doesn't actually matter here, just need it for comparison
    }

    // Update is called once per frame
    void Update()
    {
        // --- dynamically impact speed based on mouse speed ---
        //get difference between this frame and last frame's mouse position
        Vector2 curMousePosition = Mouse.current.position.ReadValue();
        float mouseDiff = Vector3.Distance(curMousePosition, lastMousePosition);
        //change background speed
        float changedBgSpeed = bgSpeed + mouseDiff;

        // --- increment position ---
        transform.position += transform.right * changedBgSpeed * Time.deltaTime;

        // --- check for reset ---
        if (transform.position.x > bgLimit)
        {// --- offscreen --- 
            // --- reset back to starting position, gives effect of looping ---
            transform.position = startPosition;
        }

        // --- update mouse position memory ---
        lastMousePosition = Mouse.current.position.ReadValue(); //mouse space (screen or world) doesn't actually matter here, just need it for comparison
    }
}
