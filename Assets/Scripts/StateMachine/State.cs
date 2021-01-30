namespace StateMachine {

    public enum States {
        BeforeStart = 0,
        Ingame = 1,
        GameOver = 2,
    }
    interface State {
        void Update();
        void Enter();
        void Exit();
    }
}
