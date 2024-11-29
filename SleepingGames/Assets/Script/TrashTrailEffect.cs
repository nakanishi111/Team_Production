using UnityEngine;

public class TrashTrailEffect : MonoBehaviour
{
    public GameObject trailEffectPrefab; // �G�t�F�N�g�̃v���n�u
    private GameObject trailEffectInstance; // �G�t�F�N�g�̃C���X�^���X
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        trailEffectInstance = Instantiate(trailEffectPrefab, transform.position, Quaternion.identity);
        trailEffectInstance.transform.parent = transform; // �G�t�F�N�g���S�~�ɒǏ]������
        trailEffectInstance.SetActive(true); // ������ԂŃG�t�F�N�g��\���ɂ���
        var emission = trailEffectInstance.GetComponent<ParticleSystem>().emission;
        emission.enabled = false; // ������ԂŃG�t�F�N�g���\���ɂ���
    }

    void Update()
    {
        if (rb.velocity.magnitude > 0.1f) // �S�~�����ł���Ƃ�
        {
            var emission = trailEffectInstance.GetComponent<ParticleSystem>().emission;
            emission.enabled = true; // �G�t�F�N�g��\������
        }
        else
        {
            var emission = trailEffectInstance.GetComponent<ParticleSystem>().emission;
            emission.enabled = false; // �G�t�F�N�g���\���ɂ���
        }
    }
}
