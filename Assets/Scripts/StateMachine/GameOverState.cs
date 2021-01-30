using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateMachine;
class GameOverState : State {


    public void Update() {
    }

    public void Enter() {
        Debug.Log(this.GetType().Name);
    }

    public void Exit() {
    }
}
