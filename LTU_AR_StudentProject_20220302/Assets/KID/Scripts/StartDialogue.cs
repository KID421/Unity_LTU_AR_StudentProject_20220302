using UnityEngine;
using UnityEngine.Events;
using Vuforia;

namespace KID
{
    public class StartDialogue : MonoBehaviour
    {
        [SerializeField]
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
