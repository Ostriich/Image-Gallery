using UnityEngine;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour
{
    public string BackSceneName;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && BackSceneName != "")
            LoadingScene.SwitchToScene(BackSceneName);
    }

    public void LoadScene(string sceneName)
    {
        gameObject.SetActive(true);
        LoadingScene.SwitchToScene(sceneName);
    }

    public void SendImageNextScene()
    {
        DataHolder.OpenImage = GetComponent<Image>().sprite;
    }
}
