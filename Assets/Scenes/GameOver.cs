using TMPro;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    [SerializeField] private GameObject gameOverText;
    [SerializeField] private float fadeDuration = 2f;

    private TextMeshProUGUI textMesh;
    private bool isFading = false;
    private float timer = 0f;
    private void Start()
    {
        if (gameOverText != null)
        {
            textMesh = gameOverText.GetComponent<TextMeshProUGUI>();
            Color c = textMesh.color;
            c.a = 0f; // 最初は透明
            textMesh.color = c;
            gameOverText.SetActive(true); // 必ず存在させる
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball") // ボールが衝突したら
        {
            
            Destroy(collision.gameObject); // ボールを削除
            isFading = true;

            
        }
    }

    private void Update()
    {
        if (isFading && textMesh != null)
        {
            timer += Time.deltaTime;
            float alpha = Mathf.Clamp01(timer / fadeDuration);
            Color c = textMesh.color;
            c.a = alpha;
            textMesh.color = c;

            if (alpha >= 1f)
            {
                isFading = false; // 完全に表示されたらフェード終了
            }
        }
    }
}
