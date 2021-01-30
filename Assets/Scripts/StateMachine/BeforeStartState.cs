using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateMachine;

public class BeforeStartState : State
{

    public float countdown = 4.0f;

    public void Update() {
        this.countdown -= Time.deltaTime;
        Debug.Log(this.countdown);
        if(countdown <= 0) {
            LevelManager.instance.changeToState(States.Ingame);
        }
    }

    public void Enter() {
        Debug.Log(this.GetType().Name);
        // @TODO: Disable Input
    }

    public void Exit() {
        Debug.Log("Exit " + this.GetType().Name);
        // @TODO: Hide Countdown UI
    }
}
