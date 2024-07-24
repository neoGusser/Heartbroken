class_name DBCharacteristics

var db = {
	1: "Heathcliff",
	2: "Catherine",
	3: "Hindly"
}

func getInfo(key: int) -> String:
	return db.get(key, "Unknown")
