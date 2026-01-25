using UnityEngine;
using UnityEngine.InputSystem;

public class flower : MonoBehaviour
{
    // --- declare variables ---
    public float lerpAmount = 0.1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // --- follow mouse position ---
        Vector3 seekPosition;
        //get mouse position, then convert it from screen to world
        Vector3 mousePosition = Mouse.current.position.ReadValue();
        Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        worldMousePosition.z = 0;

        seekPosition = worldMousePosition;
        //using a different way of lerping than in class, will adjust speed depending on distance
        transform.position = Vector3.Lerp(transform.position, seekPosition, lerpAmount * Time.deltaTime);
    }
}
