using UnityEngine;

public class AnimationCollisionHandler : MonoBehaviour
{
    public Collider2D hitCollider; // �ǉ��������R���W����
    public GameObject anime;
    // �A�j���[�V�����C�x���g�ŌĂяo����郁�\�b�h
    //public void EnableCollider()
    //{
    //    if (hitCollider != null)
    //    {
    //        hitCollider.enabled = true;
    //    }
    //}

    //public void DisableCollider()
    //{
    //    if (hitCollider != null)
    //    {
    //        hitCollider.enabled = false;
    //    }
    //}

    public void Obj_active_false()
    {
        anime.SetActive(false);
    }
    public void Obj_active_true()
    {
        anime.SetActive(true);
    }

}
