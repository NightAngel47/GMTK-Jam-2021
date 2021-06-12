using UnityEngine;

public class CharacterMovementBehaviour : MonoBehaviour
{
    private Rigidbody2D rb = null;

    [SerializeField] private float unitsPerSecond = 5f;
    private Vector3 targetDir = Vector3.zero;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (targetDir != Vector3.zero)
            Move();
    }

    private void Move()
    {
        rb.MovePosition(transform.position + targetDir * unitsPerSecond * Time.fixedDeltaTime);
    }

    public void OrderCharacterToMove(Vector2 directionToMove)
    {
        targetDir = directionToMove;
    }
}