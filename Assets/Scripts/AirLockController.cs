using UnityEngine;

public class AirLockController : MonoBehaviour
{
    [SerializeField] private GameObject gas;
    [SerializeField] private GameObject steam;

    public void VentAirLock()
    {
        gas.SetActive(false);
        steam.SetActive(true);
    }

    public void ResetAirlock()
    {
        gas.SetActive(true);
        steam.SetActive(false);
    }
}
