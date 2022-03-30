using UnityEngine;
using UnityEngine.UI;

public class VersionManager : MonoBehaviour
{
    [SerializeField, Header("����")]
    private Text textVersion;

    private void Awake()
    {
        textVersion.text = "Version " + Application.version;
    }
}
