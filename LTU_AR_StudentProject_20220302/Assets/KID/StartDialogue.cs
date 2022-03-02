using UnityEngine;
using UnityEngine.Events;
using Vuforia;

namespace KID
{
    public class StartDialogue : MonoBehaviour, IVirtualButtonEventHandler
    {
        [SerializeField]
        private UnityEvent onClick;

        private VirtualButtonBehaviour vbb;
        private string vbbName;

        private void Start()
        {
            vbb = GetComponent<VirtualButtonBehaviour>();
            vbbName = vbb.VirtualButtonName;
        }

        public void OnButtonPressed(VirtualButtonBehaviour vb)
        {
            if (vb.VirtualButtonName == vbbName) onClick?.Invoke();
        }

        public void OnButtonReleased(VirtualButtonBehaviour vb)
        {
        }
    }
}

