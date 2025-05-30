using UnityEngine;

public class PlayerGroundedState : PlayerState
{
    public PlayerGroundedState(Player _player, PlayerStateMachine playerStateMachine, string _animBoolName) : base(_player, playerStateMachine, _animBoolName)
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

        if(Input.GetKeyDown(KeyCode.Q)) //keybind for counterattack
        {
            stateMachine.ChangeState(player.counterAttack);
        }

        if(Input.GetKeyDown(KeyCode.Mouse0)) 
        {
            stateMachine.ChangeState(player.primaryAttack);
        }

        if(!player.IsGroundDetected()) 
        {
            stateMachine.ChangeState(player.airState);
        }

        if(Input.GetKeyDown(KeyCode.Space) && player.IsGroundDetected())
        {
            stateMachine.ChangeState(player.jumpState);
        }
    }


}
