using UnityEngine;

public class spacemoe : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip soundEffect;

    void Start()
    {
        // AudioSource�R���|�[�l���g���擾
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        // �X�y�[�X�L�[�������ꂽ�Ƃ��ɃT�E���h���Đ�
        if (Input.GetKeyDown(KeyCode.Space))
        {
            audioSource.PlayOneShot(soundEffect);
        }
    }
}
