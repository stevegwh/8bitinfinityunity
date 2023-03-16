using UnityEngine;

public class AccelerationEnemy : MonoBehaviour
{
    [SerializeField] private Vector2 acceleration;
    //[SerializeField] private Vector2 maxVelocity;
    private Vector2 velocity;

    [SerializeField] private bool startPatrol;
    void Start()
    {
        velocity = Vector2.zero;
    }
    
    public void TogglePatrolMovement(bool enable)
    {
        startPatrol = enable;
    }


    void Update()
    {
        if (!startPatrol) return;
        velocity += acceleration * Time.deltaTime;
        //velocity = new Vector2(Mathf.Clamp(velocity.x, 0f, maxVelocity.x), 
            //Mathf.Clamp(velocity.y, 0f, maxVelocity.y));


        transform.position += (Vector3) velocity;

    }
}
