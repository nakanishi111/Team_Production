using UnityEngine;

public class SwitchObjects : MonoBehaviour
{
    public GameObject object1; // �ŏ��ɕ\�������I�u�W�F�N�g
    public GameObject object2; // ��������ɕ\�������I�u�W�F�N�g

    void Start()
    {
        // �Q�[���J�n����object2���\���ɂ���
        object2.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // object1�̈ʒu���擾
            Vector3 position = object1.transform.position;

            // object1���\���ɂ���
            object1.SetActive(false);

            // object2��object1�̈ʒu�Ɉړ�����i�����͂��̂܂܁j
            object2.transform.position = position;
            object2.SetActive(true);

            Debug.Log("�X�y�[�X�L�[��������܂����Bobject2���\������܂����B");
        }
    }
}
