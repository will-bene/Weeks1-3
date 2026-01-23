using UnityEngine;
using UnityEngine.InputSystem;

public class TankRotation : MonoBehaviour
{
    public Camera gameCamera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentMousePosition = Mouse.current.position.ReadValue();
        Vector3 worldMousePosition = gameCamera.ScreenToWorldPoint(currentMousePosition);
        worldMousePosition.z = 0;

        //setting the direction we're looking in, to get direction you get end-start
        transform.up = worldMousePosition - transform.position;
    }
}
