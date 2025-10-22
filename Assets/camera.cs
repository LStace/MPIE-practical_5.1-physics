using UnityEngine;

public class camera : MonoBehaviour
{
    public Vector3 follow_offset = new Vector3(0.0f, 0.4f, -0.7f);
    public GameObject ball;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = ball.transform.position + follow_offset;
    }
}
