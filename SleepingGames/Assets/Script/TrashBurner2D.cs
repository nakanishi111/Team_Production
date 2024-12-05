using System.Collections;
using UnityEngine;

public class TrashBurner2D : MonoBehaviour
{
    // 燃やすゴミのオブジェクト
    public GameObject trash;
    // 5段階のスプライト
    public Sprite stage1Initial;
    public Sprite stage2Spark;
    public Sprite stage3SmallFlame;
    public Sprite stage4LargeFlame;
    public Sprite stage5Burned;
    // スプライトの変更間隔（秒）
    public float changeInterval = 0.5f;

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        // ゴミのSpriteRendererを取得
        spriteRenderer = trash.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // スペースキーが押されたとき
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(BurnTrash());
        }
    }

    private IEnumerator BurnTrash()
    {
        // ステージ2のスプライトに変更（火花）
        spriteRenderer.sprite = stage2Spark;
        yield return new WaitForSeconds(changeInterval);

        // ステージ3のスプライトに変更（小さな炎）
        spriteRenderer.sprite = stage3SmallFlame;
        yield return new WaitForSeconds(changeInterval);

        // ステージ4のスプライトに変更（大きな炎）
        spriteRenderer.sprite = stage4LargeFlame;
        yield return new WaitForSeconds(changeInterval);

        // ステージ5のスプライトに変更（燃え尽きたゴミ）
        spriteRenderer.sprite = stage5Burned;
        yield return new WaitForSeconds(changeInterval);

        // ゴミを削除
        Destroy(trash);
    }
}
