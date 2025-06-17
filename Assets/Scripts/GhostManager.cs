using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GhostManager : MonoBehaviour
{
    private List<PlayerFrameData> replayData;
    private int currentFrame = 0;
    private Rigidbody rb;
    private GhostLocomotion locomotion;
    private AnimatorManager animatorManager;

    private float moveAmount;

    public void Init(List<PlayerFrameData> data)
    {
        replayData = data;
        rb = GetComponent<Rigidbody>();
        locomotion = GetComponent<GhostLocomotion>();
        animatorManager = GetComponent<AnimatorManager>();
    }

    void FixedUpdate()
    {
        if (replayData == null || currentFrame >= replayData.Count)
            return;

        PlayerFrameData data = replayData[currentFrame];

        rb.MovePosition(data.position);
        transform.rotation = data.rotation;
        locomotion.HandleMovement();
        animatorManager.UpdateAnimatorValues(0, data.moveAmount);
        currentFrame++;
    }
}
