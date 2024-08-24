using Godot;
using System;

namespace Card
{
    public partial class CardInit : Node
    {
        private Card card;

        public void Initialize(int id)
        {
            card = new Card(id);

            Label nameNode = GetParent().GetNode<Label>("Name");
            Label hpNode = GetParent().GetNode<Label>("HP");
            Label atkNode = GetParent().GetNode<Label>("ATK");
            Label stateNode = GetParent().GetNode<Label>("State");

            nameNode.Text = card.Name;
            hpNode.Text = card.Hp.ToString();
            atkNode.Text = card.Atk.ToString();
            stateNode.Text = "Init";
        }
    }
}
