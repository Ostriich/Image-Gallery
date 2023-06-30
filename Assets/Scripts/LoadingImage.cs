using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class LoadingImage : MonoBehaviour
{
    public int NumberOfCell;

    private GameObject camera;
    private string url = "http://data.ikppbb.com/test-task-unity-data/pics/";
    private bool uploaded;

    void Start()
    {
        camera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    void Update()
    {
        if (!uploaded)
            CheckLoading();
    }

    private void CheckLoading()
    {
        Rect screenBounds = new Rect(0f, 0f, Screen.width, Screen.height);
        Vector3 objectPos = new Vector3(transform.position.x, transform.position.y, transform.position.z);

        Vector3 tempScreen;
        tempScreen = camera.GetComponent<Camera>().WorldToScreenPoint(objectPos);
        if (screenBounds.Contains(tempScreen))
        {
            uploaded = true;
            StartCoroutine(LoadImageByLink());
        }
    }

    private IEnumerator LoadImageByLink()
    {
        WWW wwwLoader = new WWW(url+ NumberOfCell.ToString()+".jpg");
        yield return wwwLoader;
        Texture2D texture2D = wwwLoader.texture;
        GetComponent<Image>().sprite = Sprite.Create(texture2D, new Rect(0.0f, 0.0f, texture2D.width, texture2D.height), new Vector2(0.5f, 0.5f));
    }
}
