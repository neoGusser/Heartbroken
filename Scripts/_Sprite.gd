class_name _Sprite

var sprite : Sprite2D
var pos : Vector2
var layoutBox : ColorRect

func _init(size : Vector2, pos : Vector2):
	layoutBox = ColorRect.new()
	sprite = Sprite2D.new()
	sprite.position = pos
