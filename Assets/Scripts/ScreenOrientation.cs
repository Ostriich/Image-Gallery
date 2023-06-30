using UnityEngine;

public class ScreenOrientation : MonoBehaviour
{
    public bool AutoOrientation;

    private void Awake()
    {
        if (AutoOrientation)
            Screen.orientation = UnityEngine.ScreenOrientation.AutoRotation;
        else
            Screen.orientation = UnityEngine.ScreenOrientation.Portrait;
    }
}
