using UnityEngine;

public class MainMenuScroll : MonoBehaviour
{

    public Vector2 startPos;

    void OnTriggerEnter2D(Collider2D col)
    {
        transform.position = startPos;
    }
}
