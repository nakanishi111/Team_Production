using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections; // ���ꂪ�K�v�ł�

public class DelayedReset : MonoBehaviour
{
    public float resetDelay = 3.0f; // ���Z�b�g�܂ł̒x�����ԁi�b�j
    private bool isResetting = false; // ���Z�b�g�����ǂ����̃t���O

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isResetting)
        {
            StartCoroutine(ResetAfterDelay());
        }
    }

    IEnumerator ResetAfterDelay() // �����炪�G���[�̌����ƂȂ�ꍇ������܂�
    {
        isResetting = true;
        yield return new WaitForSeconds(resetDelay); // �x�����Ԃ̑ҋ@
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // ���݂̃V�[���������[�h
        isResetting = false;
    }
}
