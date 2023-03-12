using UnityEngine;

public class PatrolEnemy : Enemy
{
    [SerializeField] private Vector2 velocity;
    public void ChangeDirection()
    {
        velocity *= -1;
    }

    private void Update()
    {
        transform.position += (Vector3) velocity * Time.deltaTime;
    }
}
