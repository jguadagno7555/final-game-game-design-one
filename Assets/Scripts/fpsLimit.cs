using UnityEngine;

public class fpsLimit : MonoBehaviour
{
    [SerializeField] public int vSyncCountNumber = 0;
    [SerializeField] public int frameRateNumber = 60;

    void Awake()
    {
        Application.targetFrameRate = frameRateNumber;
        QualitySettings.vSyncCount = vSyncCountNumber;  // VSync must be disabled
    }
}
