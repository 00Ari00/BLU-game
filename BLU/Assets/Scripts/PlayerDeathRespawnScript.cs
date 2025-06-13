using System.Collections;
using UnityEngine;

public class PlayerDeathRespawnScript : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;

    private Vector2 startPos;
    private float respawnTime = 0.5f;

    void Start()
    {
        startPos = transform.position;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Respawn")
        {
            Die();
        }
    }

    void Die()
    {
        StartCoroutine(Respawn(respawnTime));
    }

    IEnumerator Respawn(float duration)
    {
        spriteRenderer.enabled = false;
        yield return new WaitForSeconds(duration);
        transform.position = startPos;
        spriteRenderer.enabled = true;
    }


}
