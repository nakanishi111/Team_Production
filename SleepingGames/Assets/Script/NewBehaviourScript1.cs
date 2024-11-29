using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections; // �������m�F���Ă�������

public class SceneChanger : MonoBehaviour
{
    public string sceneToLoad; // �؂�ւ������V�[���̖��O
    private bool isTriggered = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (!isTriggered) // ������Ă΂�Ȃ��悤�ɂ���
        {
            isTriggered = true;
            StartCoroutine(ChangeSceneAfterDelay());
        }
    }

    private IEnumerator ChangeSceneAfterDelay() // �������m�F���Ă�������
    {
        yield return new WaitForSeconds(3f); // 3�b�ҋ@
        SceneManager.LoadScene(sceneToLoad); // �V�[����؂�ւ���
    }
}
