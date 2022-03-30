using UnityEngine;
using UnityEngine.UI;

public class VersionManager : MonoBehaviour
{
    [SerializeField, Header("ª©¥»")]
    private Text textVersion;

    private void Awake()
    {
        textVersion.text = "Version " + Application.version;
    }
}
