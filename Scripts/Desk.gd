extends Node2D

func _on_back_pressed():
	get_tree().change_scene_to_file("res://Scenes/menu.tscn")

func _ready():
	
	var playerCards = [ 
		Card.new(2, [], Vector2(344, 117)), 
		Card.new(1, [], Vector2(942, 117)), 
		Card.new(3, [], Vector2(653, 117))
	]
	
	var enemyCards = [ 
		Card.new(2, [], Vector2(344, 10)), 
		Card.new(1, [], Vector2(942, 10)), 
		Card.new(3, [], Vector2(653, 10))
	]
	
	var allCards = playerCards + enemyCards 
	
	for card in allCards:
		add_child(card.getSprite())


