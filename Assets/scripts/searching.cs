using UnityEngine;

public class searching : MonoBehaviour
{
    public Vector2 startPos;
    public Vector2 endPos;
    public float progress;
    public float duration;
    public Vector2 output;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = startPos;
        endPos = Random.insideUnitCircle * 5;
    }

    // Update is called once per frame
    void Update()
    {
        progress += Time.deltaTime / duration;
        output = Vector2.Lerp(startPos, endPos, progress);
        transform.position = output;
        if (progress >= 1)
        {//finished movement
            startPos = endPos;
            endPos = Random.insideUnitCircle * 5;
            progress = 0;
        }
        
    }
}
