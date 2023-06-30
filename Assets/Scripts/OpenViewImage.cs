using UnityEngine;
using UnityEngine.UI;

public class OpenViewImage : MonoBehaviour
{
    void Start()
    {
        GetComponent<Image>().sprite = DataHolder.OpenImage;
    }
}
