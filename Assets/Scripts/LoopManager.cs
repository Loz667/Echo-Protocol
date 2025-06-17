using System.Collections.Generic;
using UnityEngine;

public class LoopManager : MonoBehaviour
{
    [SerializeField] private float loopDuration = 30f;
    private float timer;

    [SerializeField] private GameObject ghostPrefab;
    private PlayerManager player;

    private PlayerRecorder recorder;
    private List<List<PlayerFrameData>> pastRuns = new List<List<PlayerFrameData>>();

    void Start()
    {
        player = FindFirstObjectByType<PlayerManager>();
        recorder = player.GetComponent<PlayerRecorder>();
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
        List<PlayerFrameData> run = recorder.GetRecordedData();
        pastRuns.Add(run);

        if (run.Count > 0)
        {
            GameObject ghost = Instantiate(ghostPrefab, run[0].position, ghostPrefab.transform.rotation);
            ghost.GetComponent<GhostManager>().Init(run);
        }

        recorder.ClearData();
    }

    public float GetRemainingTime() => loopDuration - timer;
}
