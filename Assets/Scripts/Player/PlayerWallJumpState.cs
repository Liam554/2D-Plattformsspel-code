using UnityEngine;

public class PlayerWallJumpState : PlayerState
{
    public PlayerWallJumpState(Player _player, PlayerStateMachine playerStateMachine, string _animBoolName) : base(_player, playerStateMachine, _animBoolName)
    {
    }

    public override void Enter()
    {
        base.Enter();

        stateTimer = .4f;
        player.SetLVelocity(5 * -player.facingDir, player.jumpForce); 
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void Update()
    {
        base.Update();

        if (stateTimer > 0)
        {
            stateMachine.ChangeState(player.airState);
        }

        if(player.IsGroundDetected()) 
        {
            stateMachine.ChangeState(player.idleState);

        }
    }

}
