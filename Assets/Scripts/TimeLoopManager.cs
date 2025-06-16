using System.Collections.Generic;
using UnityEngine;

public class TimeLoopManager : MonoBehaviour
{
    [SerializeField] private float loopDuration = 30f;
    private float timer;

    [SerializeField] private GameObject ghostPrefab;
    private PlayerMovement player;

    private Recorder recorder;
    private List<List<FrameData>> pastRuns = new List<List<FrameData>>();

    void Start()
    {
        player = FindFirstObjectByType<PlayerMovement>();
        recorder = player.GetComponent<Recorder>();
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= loopDuration)
        {
            StartNewLoop();
            timer = 0;
        }
    }

    void StartNewLoop()
    {
        List<FrameData> run = recorder.GetRecordedData();
        pastRuns.Add(run);

        if (run.Count > 0)
        {
            GameObject ghost = Instantiate(ghostPrefab, run[0].position, ghostPrefab.transform.localRotation);
            ghost.GetComponent<Ghost>().Init(run);
        }

        recorder.ClearData();
    }

    public float GetRemainingTime() => loopDuration - timer;
}
