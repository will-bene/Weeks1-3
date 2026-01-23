using UnityEngine;
using UnityEngine.InputSystem;

public class Controller : MonoBehaviour
{
    public float rotationSpeed = 30;
    public float moveSpeed = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //bool leftIsHeld = Mouse.current.leftButton.isPressed;
        //if (leftIsHeld)
        //{
        //    Debug.Log("Left mouse is held");
        //}

        //bool leftIsPressed = Mouse.current.leftButton.wasPressedThisFrame;
        //if (leftIsPressed)
        //{
        //    Debug.Log("Left mouse is pressed.");
        //}

        //bool leftIsReleased = Mouse.current.leftButton.wasReleasedThisFrame;
        //if (leftIsReleased)
        //{
        //    Debug.Log("Left mouse is released.");
        //}

        bool rightKeyPressed = Keyboard.current.rightArrowKey.isPressed;
        if (rightKeyPressed)
        {
            transform.eulerAngles += transform.forward * rotationSpeed * Time.deltaTime;
        }
        bool leftPressed = Keyboard.current.leftArrowKey.isPressed;
        if (leftPressed)
        {
            transform.eulerAngles -= transform.forward * rotationSpeed * Time.deltaTime;
        }
        bool upKeyPressed = Keyboard.current.upArrowKey.isPressed;
        if (upKeyPressed)
        {
            transform.position += transform.up * moveSpeed * Time.deltaTime;
        }
        bool downKeyPressed = Keyboard.current.downArrowKey.isPressed;
        if (downKeyPressed)
        {
            transform.position -= transform.up * moveSpeed * Time.deltaTime;
        }
    }
}
