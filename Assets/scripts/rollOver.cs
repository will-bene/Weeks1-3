using UnityEngine;
using UnityEngine.InputSystem;

public class rollOver : MonoBehaviour
{
    public bool timerIsRunning = false;
    public float timer = 0;
    public Camera gameCamera;
    public AnimationCurve curve;
    public float mouseDistance;
    public float output;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 curMousePosition = Mouse.current.position.ReadValue();
        Vector3 worldMousePosition = gameCamera.ScreenToWorldPoint(curMousePosition);
        worldMousePosition.z = 0;

        float distanceToMouse = Vector2.Distance(worldMousePosition, transform.position);

        if (distanceToMouse <= mouseDistance)
        {
            timerIsRunning = true;
        }
        else
        {
            timer = 0;
            timerIsRunning = false;
        }

        if (timerIsRunning)
        {
            timer += Time.deltaTime;
            if (timer >= 1)
            { timer = 0; }

        }
        output = curve.Evaluate(timer);
        transform.localScale = Vector3.one * output;

    }
}
