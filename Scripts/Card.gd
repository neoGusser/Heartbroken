class_name Card

var id: int = 0
var name: String
var hp: int
var skillSet = []
var sprite: Sprite2D
var cardFull: bool = true

func _init(id: int, skillSet, pos: Vector2 = Vector2.ZERO):
	self.id = id
	var characteristics = DBCharacteristics.new()
	self.name = characteristics.getInfo(id)
	self.hp = 100
	self.skillSet = skillSet
	
	self.sprite = Sprite2D.new()
	sprite.texture = preload("res://Sprites/card.png")
	sprite.position = pos

func attack(damage: int, card: Card):
	card.hp -= damage

func cardisBroken():
	cardFull = hp > 0

func getSprite() -> Sprite2D:
	return sprite
	

