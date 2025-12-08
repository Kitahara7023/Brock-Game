using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Block : MonoBehaviour
{
    private SpriteRenderer sr;



    void Start()
    {
        sr = GetComponent<SpriteRenderer>();

        Color c = sr.color;
        c.a = 255f;
        sr.color = c;
    }

    public void Initialize()
    {
        StartCoroutine(FadeIn(1.0f));
    }

    public void OnStart()
    {

    }

    public void OnUpdate()
    {

    }

    private IEnumerator FadeIn(float duration)
    {
        float elapsed = 0f;

        Color c = sr.color;
        float startA = 0f;
        float endA = 1f;

        while (elapsed < duration)
        {
            elapsed += Time.deltaTime;
            float t = elapsed / duration;

            c.a = Mathf.Lerp(startA, endA, t);
            sr.color = c;

            yield return null;
        }

        c.a = 1f;
        sr.color = c;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            Destroy(this.gameObject);
        }
    }
}
