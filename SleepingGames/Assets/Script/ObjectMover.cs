using UnityEngine;

public class ObjectMover : MonoBehaviour
{
    public float amplitude = 1f; // �ړ��̕�
    public float speed = 1f; // �ړ��̑���

    private Vector3 startPos;

    void Start()
    {
        // �I�u�W�F�N�g�̏����ʒu��ۑ�
        startPos = transform.position;
    }

    void Update()
    {
        // �I�u�W�F�N�g���㉺�ɓ�����
        float newY = startPos.y + amplitude * Mathf.Sin(Time.time * speed);
        transform.position = new Vector3(startPos.x, newY, startPos.z);
    }
}
