using UnityEngine;

public class goru : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip collisionSound;

    void OnTriggerEnter(Collider other)
    {
        // ���������I�u�W�F�N�g���ugomibako�v�^�O�������Ă��邩�m�F
        if (other.CompareTag("gomibako"))
        {
            // �T�E���h���Đ�
            audioSource.PlayOneShot(collisionSound);
        }
    }
}
