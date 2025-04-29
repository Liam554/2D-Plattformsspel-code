public class PlayerAirState : PlayerState
{
    public PlayerAirState(Player _player, PlayerStateMachine playerStateMachine, string _animBoolName) : base(_player, playerStateMachine, _animBoolName)
    {
    }

    public override void Enter()
    {
        base.Enter();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void Update()
    {
        base.Update();

        if (player.IsGroundDetected())
        {
            stateMachine.ChangeState(player.idleState);
        }

        if(player.IsWallDetected()) 
        {
            stateMachine.ChangeState(player.wallSlide);
        }

        if(xInput != 0)
        {
            player.SetLVelocity(player.moveSpeed * .8f * xInput, rb.linearVelocity.y);
        }
    }
}
