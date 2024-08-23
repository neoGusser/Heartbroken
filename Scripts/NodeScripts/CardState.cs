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
            Dragging,
            Attacking,
            Cancel
        }

        private State currentState = State.Init;
        private Card card;

        public override void _Ready()
        {
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

                    card = new Card(1);
                    Label nameNode = GetParent().GetNode<Label>("Name");
                    Label hpNode = GetParent().GetNode<Label>("HP");
                    Label atkNode = GetParent().GetNode<Label>("ATK");

                    nameNode.Text = card.Name;
                    hpNode.Text = card.Hp.ToString();
                    atkNode.Text = "9";

                    stateNode.Text = "Init";

                    ChangeState(State.Idle);

                    break;

                case State.Idle:
                    stateNode.Text = "Idle";
                    break;

                case State.Dragging:
                    stateNode.Text = "Drag";
                    break;

                case State.Attacking:
                    stateNode.Text = "Atk";
                    break;

                case State.Cancel:
                    stateNode.Text = "Cancle";
                    break;
            }
        }
    }
}
