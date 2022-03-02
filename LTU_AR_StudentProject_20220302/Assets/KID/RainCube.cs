using UnityEngine;

public class RainCube : MonoBehaviour
{
    public float maxSize = 0.5f;

    private void OnParticleCollision(GameObject other)
    {
        Vector3 scale = transform.localScale;       // 取得當前尺寸
        scale.y += 0.005f;                          // Y 累加
        scale.y = Mathf.Clamp(scale.y, 0, maxSize); // 夾住 0 - 0.5
        transform.localScale = scale;               // 更新尺寸
    }
}
