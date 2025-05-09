using UnityEngine;
using System.Collections.Generic;
using System.Collections;


public class PlayerStateMachine 
{
    public PlayerState currentState {  get; private set; }

    public void Initilize(PlayerState _startState)
    {
        currentState = _startState;
        currentState.Enter();
    }

    public void ChangeState(PlayerState _newState)
    {
        currentState.Exit();
        currentState = _newState;
        currentState.Enter();
    }

}
