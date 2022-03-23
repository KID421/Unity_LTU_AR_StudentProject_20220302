using UnityEngine;
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

        private VirtualButtonBehaviour vbb;

        private void Start()
        {
            vbb = GetComponent<VirtualButtonBehaviour>();
            vbb.RegisterOnButtonPressed(OnButtonPressed);
            vbb.RegisterOnButtonReleased(OnButtonReleased);
        }

        public void OnButtonPressed(VirtualButtonBehaviour vb)
        {
            onClick?.Invoke();
        }

        public void OnButtonReleased(VirtualButtonBehaviour vb)
        {
        }
    }
}
