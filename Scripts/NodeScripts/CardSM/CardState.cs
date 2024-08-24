using Godot;
using System;

namespace Card
{
    public partial class CardState : Node
    {
        private enum State
        {
            Init,
            Idle,
            Drag
        }

        private State currentState = State.Init;
        private Card card;
        private Vector2 initialPosition;
        private bool PosHasExecuted = false;

        public void Initialize(int id)
        {
            card = new Card(id);
            ChangeState(State.Init);
        }

        private void ChangeState(State newState)
        {
            currentState = newState;
            EnterState(currentState);
        }

        private void EnterState(State state)
        {
            Label stateNode = GetParent().GetNode<Label>("State");

            switch (state)
            {
                case State.Init:
                    InitializeCard();
                    ChangeState(State.Idle);
                    break;

                case State.Idle:
                    stateNode.Text = "Idle";
                    break;

                case State.Drag:
                    stateNode.Text = "Drag";
                    break;
            }
        }

        private void InitializeCard()
        {
            Label nameNode = GetParent().GetNode<Label>("Name");
            Label hpNode = GetParent().GetNode<Label>("HP");
            Label atkNode = GetParent().GetNode<Label>("ATK");

            nameNode.Text = card.Name;
            hpNode.Text = card.Hp.ToString();
            atkNode.Text = card.Atk.ToString();
        }

        public override void _Input(InputEvent @event)
        {
            Control cardControl = GetParent<Control>();

            if (@event is InputEventMouseButton mouseEvent)
            {
                if (mouseEvent.ButtonIndex == MouseButton.Left && mouseEvent.Pressed)
                {
                    if (cardControl.GetRect().HasPoint(cardControl.GetLocalMousePosition()))
                    {
                        if (currentState == State.Idle)
                        {
                            if(PosHasExecuted!){
                                initialPosition = GetParent<Control>().Position;
                            }
                            ChangeState(State.Drag);
                        }
                    }
                }
                else if (mouseEvent.ButtonIndex == MouseButton.Left && !mouseEvent.Pressed)
                {
                    if (currentState == State.Drag)
                    {
                        cardControl.Position = initialPosition;
                        ChangeState(State.Idle);
                    }
                }
            }
            else if (@event is InputEventMouseMotion motionEvent && currentState == State.Drag)
            {
                cardControl.Position += motionEvent.Relative;
            }
        }
    }
}
