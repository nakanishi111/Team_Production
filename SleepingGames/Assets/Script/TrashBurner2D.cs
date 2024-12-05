using System.Collections;
using UnityEngine;

public class TrashBurner2D : MonoBehaviour
{
    // �R�₷�S�~�̃I�u�W�F�N�g
    public GameObject trash;
    // 5�i�K�̃X�v���C�g
    public Sprite stage1Initial;
    public Sprite stage2Spark;
    public Sprite stage3SmallFlame;
    public Sprite stage4LargeFlame;
    public Sprite stage5Burned;
    // �X�v���C�g�̕ύX�Ԋu�i�b�j
    public float changeInterval = 0.5f;

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        // �S�~��SpriteRenderer���擾
        spriteRenderer = trash.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // �X�y�[�X�L�[�������ꂽ�Ƃ�
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(BurnTrash());
        }
    }

    private IEnumerator BurnTrash()
    {
        // �X�e�[�W2�̃X�v���C�g�ɕύX�i�Ήԁj
        spriteRenderer.sprite = stage2Spark;
        yield return new WaitForSeconds(changeInterval);

        // �X�e�[�W3�̃X�v���C�g�ɕύX�i�����ȉ��j
        spriteRenderer.sprite = stage3SmallFlame;
        yield return new WaitForSeconds(changeInterval);

        // �X�e�[�W4�̃X�v���C�g�ɕύX�i�傫�ȉ��j
        spriteRenderer.sprite = stage4LargeFlame;
        yield return new WaitForSeconds(changeInterval);

        // �X�e�[�W5�̃X�v���C�g�ɕύX�i�R���s�����S�~�j
        spriteRenderer.sprite = stage5Burned;
        yield return new WaitForSeconds(changeInterval);

        // �S�~���폜
        Destroy(trash);
    }
}
