using NUnit.Framework;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections.Generic;

public class Controller : MonoBehaviour
{
    public float rotationSpeed = 30;
    public float moveSpeed = 1;
    public SpriteRenderer spriteRenderer;
    public Color startingColor = Color.blue;

    public List<SpriteRenderer> controllableRenderers;

    public List<Transform> controlledTransform;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bool isInsideObject = spriteRenderer.bounds.Contains(transform.position);
        controlledTransform.Add(transform);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentMousePosition = Mouse.current.position.ReadValue();
        Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(currentMousePosition);
        worldMousePosition.z = 0;

        bool isLeftMousePressed = Mouse.current.leftButton.wasPressedThisFrame;
        if (isLeftMousePressed)
        {
            //find any controllers that are currently hovered over
            for (int i = 0; i < controllableRenderers.Count; i++)
            { 
                SpriteRenderer currentSpriteRenderer=controllableRenderers[i];
                bool isHovered = currentSpriteRenderer.bounds.Contains(worldMousePosition);
                if (isHovered)
                {
                    controlledTransform.Add(currentSpriteRenderer.transform);
                }
            }
        }

        for (int i = 0; i < controlledTransform.Count; i++)
        {
            Transform currentTransform = controlledTransform[i];
            bool rightKeyPressed = Keyboard.current.rightArrowKey.isPressed;
            if (rightKeyPressed)
            {
                currentTransform.eulerAngles += currentTransform.forward * rotationSpeed * Time.deltaTime;
            }
            bool leftPressed = Keyboard.current.leftArrowKey.isPressed;
            if (leftPressed)
            {
                currentTransform.eulerAngles -= currentTransform.forward * rotationSpeed * Time.deltaTime;
            }
            bool upKeyPressed = Keyboard.current.upArrowKey.isPressed;
            if (upKeyPressed)
            {
                currentTransform.position += currentTransform.up * moveSpeed * Time.deltaTime;
            }
            bool downKeyPressed = Keyboard.current.downArrowKey.isPressed;
            if (downKeyPressed)
            {
                currentTransform.position -= currentTransform.up * moveSpeed * Time.deltaTime;
            }
        }
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

        //bool rightKeyPressed = Keyboard.current.rightArrowKey.isPressed;
        //if (rightKeyPressed)
        //{
        //    transform.eulerAngles += transform.forward * rotationSpeed * Time.deltaTime;
        //}
        //bool leftPressed = Keyboard.current.leftArrowKey.isPressed;
        //if (leftPressed)
        //{
        //    transform.eulerAngles -= transform.forward * rotationSpeed * Time.deltaTime;
        //}
        //bool upKeyPressed = Keyboard.current.upArrowKey.isPressed;
        //if (upKeyPressed)
        //{
        //    transform.position += transform.up * moveSpeed * Time.deltaTime;
        //}
        //bool downKeyPressed = Keyboard.current.downArrowKey.isPressed;
        //if (downKeyPressed)
        //{
        //    transform.position -= transform.up * moveSpeed * Time.deltaTime;
        //}
    }
}
