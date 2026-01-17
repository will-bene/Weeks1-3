using System.Threading;
using UnityEngine;

public class ocean : MonoBehaviour
{
    public float t=0;
    public float spd;
    public AnimationCurve curve;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += spd * Time.deltaTime;
        Vector2 newTransform = new Vector2(transform.position.x, curve.Evaluate(t));
        transform.position = newTransform;
        if (t>=1)
        {
            t = 0;
        }
    }
}
