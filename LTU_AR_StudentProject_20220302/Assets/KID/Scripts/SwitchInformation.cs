using UnityEngine;

public class SwitchInformation : MonoBehaviour
{
    public void SwitchInformationUI(GameObject goUI)
    {
        goUI.SetActive(!goUI.activeInHierarchy);
    }
}
