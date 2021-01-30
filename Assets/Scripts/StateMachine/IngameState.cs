using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateMachine;


class IngameState : State {

    public void Update() {
    }

    public void Enter() {
        Debug.Log("Enter " + this.GetType().Name);
        // @TODO: Enable Input
    }

    public void Exit() {
    }
}
