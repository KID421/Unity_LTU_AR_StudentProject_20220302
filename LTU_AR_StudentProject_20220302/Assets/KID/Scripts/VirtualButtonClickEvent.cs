using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using Vuforia;

namespace KID
{
    /// <summary>
    /// 虛擬按鈕點擊事件
    /// </summary>
    public class VirtualButtonClickEvent : MonoBehaviour
    {
        [SerializeField, Header("虛擬按鈕點擊事件")]
        private UnityEvent onClick;
        [SerializeField, Header("虛擬按鈕放開事件")]
        private UnityEvent onReleased;

        private VirtualButtonBehaviour vbb;
        private Text textTest;

        private void Start()
        {
            textTest = GameObject.Find("測試文字").GetComponent<Text>();

            vbb = GetComponent<VirtualButtonBehaviour>();
            vbb.RegisterOnButtonPressed(OnButtonPressed);
            vbb.RegisterOnButtonReleased(OnButtonReleased);
        }

        public void OnButtonPressed(VirtualButtonBehaviour vb)
        {
            onClick?.Invoke();

            textTest.text += "<color=red>" + vb.VirtualButtonName + " 被點擊。</color>";
            
        }

        public void OnButtonReleased(VirtualButtonBehaviour vb)
        {
            onReleased?.Invoke();

            textTest.text += "<color=yellow>" + vb.VirtualButtonName + " 被放開。</color>";
        }
    }
}
