using UnityEngine;
public class TrashDisappearAndFire : MonoBehaviour 
{ public GameObject firePrefab; // 火のプレハブ
private bool isDestroyed; 
    void Update() 
    { 
        if (Input.GetKeyDown(KeyCode.Space) && !isDestroyed) 
        { isDestroyed = true; Vector3 spawnPosition = transform.position; Destroy(gameObject); // ゴミを消す
            GameObject fire = Instantiate(firePrefab, spawnPosition, Quaternion.identity); Destroy(fire, 1f); // 2秒後に火のエフェクトを消す
        }
    }
}