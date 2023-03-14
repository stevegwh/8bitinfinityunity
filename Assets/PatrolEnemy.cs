using UnityEngine;

public class PatrolEnemy : Enemy
{
    [SerializeField] protected Vector2 velocity;
    [SerializeField] protected bool startPatrol = true;
    public void ChangeDirection()
    {
        velocity *= -1;
    }

    public void TogglePatrolMovement(bool enable)
    {
        startPatrol = enable;
    }

    private void Update()
    {
        if (!startPatrol) return;
        transform.position += (Vector3) velocity * Time.deltaTime;
    }
}
