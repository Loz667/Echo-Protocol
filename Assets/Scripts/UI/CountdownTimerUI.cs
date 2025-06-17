using TMPro;
using UnityEngine;

public class CountdownTimerUI : MonoBehaviour
{
    [SerializeField] private LoopManager loopManager;
    [SerializeField] private TextMeshProUGUI timerText;

    void Update()
    {
        float timeLeft = loopManager.GetRemainingTime();
        timerText.text = $"Next Loop In: {timeLeft:F1}s";
    }
}
