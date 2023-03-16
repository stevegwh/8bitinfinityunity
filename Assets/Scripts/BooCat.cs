using UnityEngine;
using UnityEngine.InputSystem;

public class BooCat : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private float speed = 3f;
    [SerializeField] private Player playerScript;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Sprite evilSprite;
    [SerializeField] private Sprite goodSprite;
    [SerializeField] private BoxCollider2D boxCollider2D;

    private Vector3 originalPos;
    private void Awake()
    {
        originalPos = transform.position;
    }
    
    void Update()
    {
        if (!playerScript.startFollowMouse) return;
        float step = speed * Time.deltaTime;
        var mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        var playerPos = player.transform.position;
        if (mousePos.x > playerPos.x && transform.position.x < playerPos.x || mousePos.x < playerPos.x && transform.position.x > playerPos.x)
            //|| mousePos.y > playerPos.y && transform.position.y < playerPos.y || mousePos.x < playerPos.y && transform.position.x > playerPos.y)
        {
            boxCollider2D.enabled = true;
            spriteRenderer.sprite = evilSprite;
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, 
                step);
        }
        else
        {
            boxCollider2D.enabled = false;
            step /= 2;
            spriteRenderer.sprite = goodSprite;
            transform.position = Vector2.MoveTowards(transform.position, originalPos, 
                step);
        }

    }
}
