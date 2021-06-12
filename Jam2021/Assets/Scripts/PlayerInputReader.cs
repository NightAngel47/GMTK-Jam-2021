using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class PlayerInputReader : MonoBehaviour
{
    private CharacterMovementBehaviour movement = null;

    private Vector2 directionToMove = Vector2.zero;

    private void Awake()
    {
        movement = GetComponent<CharacterMovementBehaviour>();
    }

    private void Update()
    {
        movement.OrderCharacterToMove(directionToMove);
    }

    public void PlayerWantsToMove(CallbackContext context)
    {
        directionToMove = context.ReadValue<Vector2>();
    }
}