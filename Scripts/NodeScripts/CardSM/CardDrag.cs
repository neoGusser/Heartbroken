using Godot;
using System;

public partial class CardDrag : Node
{
    private Vector2 _dragOffset;
    private bool _isDragging;

    

    public override void _Input(InputEvent @event)
    {
        if (@event is InputEventMouseButton mouseButtonEvent)
        {
            if (mouseButtonEvent.ButtonIndex == MouseButton.Left)
            {
                if (mouseButtonEvent.Pressed)
                {
                    // if (GetGlobalRect().HasPoint(mouseButtonEvent.Position))
                    // {
                    //     _isDragging = true;
                    //     _dragOffset = GlobalPosition - mouseButtonEvent.GlobalPosition;
                    //     GetTree().SetInputAsHandled();
                    // }
                }
                else
                {
                    _isDragging = false;
                }
            }
        }
        else if (@event is InputEventMouseMotion mouseMotionEvent)
        {
            if (_isDragging)
            {
                // GlobalPosition = mouseMotionEvent.GlobalPosition + _dragOffset;
                // GetTree().SetInputAsHandled();
            }
        }
    }
}
