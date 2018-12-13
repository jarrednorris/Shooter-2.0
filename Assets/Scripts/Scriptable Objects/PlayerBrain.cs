using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Brains/PlayerBrain")]
public class PlayerBrain : PawnBrain
{
    public PlayerAbilities abilities;
    public float playerBaseSpeed = 5.0f;

    public override void ProcessMovement(Movement movement, float time, float startHeight)
    {
        float playerMoveHorizontal = Input.GetAxis("Horizontal");
        float playerMoveVertical = Input.GetAxis("Vertical");

        Vector2 moveInput;
        moveInput.x = playerMoveHorizontal;
        moveInput.y = playerMoveVertical * 0.8f;

        movement.Move(moveInput * (playerBaseSpeed + abilities.speedBuff.amount) * Time.deltaTime);
    }
}