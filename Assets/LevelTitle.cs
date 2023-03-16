using TMPro;
using UnityEngine;

public class LevelTitle : MonoBehaviour
{
    [SerializeField] private SpriteRenderer background;
    [SerializeField] private GameObject player;
    [SerializeField] private TextMeshProUGUI text;

    private readonly string[] failText =
    {
        "Try again...",
        "Come on, now",
        "This time you'll get it!",
        "Oh no...",
        "Ok, this is getting awkward.",
        "Don't blame the game designer",
        "You can't quit now.",
        "You'll miss out on the awesome ending!",
        "Welp..."
    };

    void Start()
    {
        if (GameManager.levelRestartCounter > 0) SetFailText();
        background.sortingOrder = 2;
        player.gameObject.SetActive(false);
        Invoke(nameof(DisableTitleText), 0.75f);
        
    }

    private void SetFailText()
    {
        var i = GameManager.levelRestartCounter - 1 >= failText.Length - 1
            ? failText.Length - 1
            : GameManager.levelRestartCounter - 1;
        text.text = failText[i];
    }

    private void DisableTitleText()
    {
        background.sortingOrder = -1;
        player.gameObject.SetActive(true);
        gameObject.SetActive(false);
    }
}
