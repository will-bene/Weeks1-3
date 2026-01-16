using UnityEngine;

public class searching : MonoBehaviour
{
    public Vector2 startPos;
    public Vector2 endPos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = startPos;
        endPos = Random.insideUnitCircle * 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
