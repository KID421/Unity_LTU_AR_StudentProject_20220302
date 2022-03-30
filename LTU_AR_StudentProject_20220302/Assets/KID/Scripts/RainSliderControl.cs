using UnityEngine;

namespace KID
{
    public class RainSliderControl : MonoBehaviour
    {
        [SerializeField]
        private ParticleSystem psRain;

        public void SetRainParticle(float value)
        {
            var emission = psRain.emission;
            // emission.rateOverTimeMultiplier *= value;
            emission.rateOverTime = value;
        }
    }
}

