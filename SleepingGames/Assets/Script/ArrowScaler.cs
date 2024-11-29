using UnityEngine;

public class ArrowScaler : MonoBehaviour
{
    public float maxLength = 3.0f; // �ő咷��
    public float minLength = 0.0f; // �ŏ�����
    private bool isShooting = false; // ���˒����ǂ�����ǐ�

    public void SetLength(float length)
    {
        if (!isShooting)
        {
            Vector3 scale = transform.localScale;
            scale.y = Mathf.Clamp(length, minLength, maxLength);
            transform.localScale = scale;
        }
    }

    public void SetRotation(Vector3 direction)
    {
        if (!isShooting)
        {
            transform.up = direction; // ���̌�����ݒ�
        }
    }

    public void StartShooting()
    {
        isShooting = true;
    }

    public void StopShooting()
    {
        isShooting = false;
    }
}
