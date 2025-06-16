using System.Collections.Generic;
using UnityEngine;

public class FrameData
{
    public Vector2 position;
    public Vector2 input;
}

public class Recorder : MonoBehaviour
{
    private List<FrameData> currentRun = new List<FrameData>();
    private PlayerMovement player;

    void Start()
    {
        player = GetComponent<PlayerMovement>();
    }

    void FixedUpdate()
    {
        FrameData data = new FrameData
        {
            position = transform.position,
            input = player.GetCurrentInput()
        };
        currentRun.Add(data);
    }

    public List<FrameData> GetRecordedData()
    {
        return new List<FrameData>(currentRun); // Return a copy
    }

    public void ClearData() => currentRun.Clear();
}
