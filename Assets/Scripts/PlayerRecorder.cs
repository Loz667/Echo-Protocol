using System.Collections.Generic;
using UnityEngine;

public class PlayerFrameData
{
    public Vector2 input;
    public Vector3 position;
    public Quaternion rotation;
    public float moveAmount;
}

public class PlayerRecorder : MonoBehaviour
{
    private List<PlayerFrameData> currentRun = new List<PlayerFrameData>();
    private InputManager player;

    void Start()
    {
        player = GetComponent<InputManager>();
    }

    void FixedUpdate()
    {
        PlayerFrameData data = new PlayerFrameData
        {
            input = player.GetCurrentInput(),
            position = transform.position,
            rotation = transform.rotation,
            moveAmount = player.GetMoveAmount()
        };
        currentRun.Add(data);
    }

    public List<PlayerFrameData> GetRecordedData()
    {
        return new List<PlayerFrameData>(currentRun); // Return a copy
    }

    public void ClearData() => currentRun.Clear();
}
