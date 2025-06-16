using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Ghost : MonoBehaviour
{
    private List<FrameData> replayData;
    private int currentFrame = 0;
    private Rigidbody2D rb;

    public void Init(List<FrameData> data)
    {
        replayData = data;
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (replayData == null || currentFrame >= replayData.Count)
            return;

        rb.MovePosition(replayData[currentFrame].position);
        currentFrame++;
    }
}
