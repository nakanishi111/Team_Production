using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class DelayedSceneSwitcher : MonoBehaviour
{
    public string sceneToLoad; // �؂�ւ������V�[���̖��O
    public float delay = 3f; // �V�[����؂�ւ���܂ł̒x�����ԁi�b�j

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("gomi"))
        {
            Debug.Log("����̃I�u�W�F�N�g�ɐڐG���܂����B�V�[����؂�ւ��܂��B");
            StartCoroutine(ChangeSceneAfterDelay());
        }
    }

    private IEnumerator ChangeSceneAfterDelay()
    {
        Debug.Log("�V�[���؂�ւ��̂��߂̒x�����J�n���܂��B");
        yield return new WaitForSeconds(delay); // �x�����Ԃ�ҋ@
        Debug.Log("�x�����������܂����B�V�[����؂�ւ��܂��B");
        SceneManager.LoadScene(sceneToLoad); // �V�[����؂�ւ���
    }
}
