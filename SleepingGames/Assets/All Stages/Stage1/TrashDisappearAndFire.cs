using UnityEngine;
public class TrashDisappearAndFire : MonoBehaviour 
{ public GameObject firePrefab; // �΂̃v���n�u
private bool isDestroyed; 
    void Update() 
    { 
        if (Input.GetKeyDown(KeyCode.Space) && !isDestroyed) 
        { isDestroyed = true; Vector3 spawnPosition = transform.position; Destroy(gameObject); // �S�~������
            GameObject fire = Instantiate(firePrefab, spawnPosition, Quaternion.identity); Destroy(fire, 1f); // 2�b��ɉ΂̃G�t�F�N�g������
        }
    }
}