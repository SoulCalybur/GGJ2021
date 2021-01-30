using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateMachine;

public class LevelManager : MonoBehaviour
{

    public static LevelManager instance = null;
    private State _currentState;

    void Awake() {
        if(instance == null) {
            instance = this;
        } else if(instance != this) {
            Object.Destroy(gameObject);
        }
    }

    public void changeToState(States state) {
        this._currentState.Exit();

        switch (state) {
            case States.BeforeStart:
                this._currentState = new BeforeStartState();
                break;
            case States.Ingame:
                this._currentState = new IngameState();
                break;
            case States.GameOver:
                this._currentState = new GameOverState();
                break;
            default:
                break;
        }
        this._currentState.Enter();
    }

    void OnEnable() {
        this._currentState = new BeforeStartState();
    }

    void Update() {
        this._currentState.Update();
    }
}
