// Unique
if (document.title.includes("Commoner") || document.title.includes("Noble") || document.title.includes("Dancer") || document.title.includes("Enlightened One") || document.title.includes("Armored Lord") || document.title.includes("Emperor") || document.title.includes("High Lord") || document.title.includes("Great Lord") || document.title.includes("Wyvern Master") || document.title.includes("Barbarossa")) {
    $("#unique").addClass("show");
}

// Beginner
if (document.title.includes("Myrmidon") || document.title.includes("Soldier") || document.title.includes("Fighter") || document.title.includes("Monk")) {
    $("#beginner").addClass("show");
}

// Intermediate
if (document.title.includes("Lord") || document.title.includes("Mercenary") || document.title.includes("Thief") || document.title.includes("Armored Knight") || document.title.includes("Cavalier") || document.title.includes("Brigand") || document.title.includes("Archer") || document.title.includes("Brawler") || document.title.includes("Mage") || document.title.includes("Dark Mage") || document.title.includes("Priest") || document.title.includes("Pegasus Knight")) {
    $("#intermediate").addClass("show");
}

// Advanced
if (document.title.includes("Hero") || document.title.includes("Swordmaster") || document.title.includes("Assassin") || document.title.includes("Fortress Knight") || document.title.includes("Paladin") || document.title.includes("Wyvern Rider") || document.title.includes("Warrior") || document.title.includes("Sniper") || document.title.includes("Grappler") || document.title.includes("Warlock") || document.title.includes("Dark Bishop") || document.title.includes("Bishop")) {
    $("#advanced").addClass("show");
}

// Master
if (document.title.includes("Falcon Knight") || document.title.includes("Wyvern Lord") || document.title.includes("Mortal Savant") || document.title.includes("Great Knight") || document.title.includes("Bow Knight") || document.title.includes("Dark Knight") || document.title.includes("Holy Knight") || document.title.includes("War Master") || document.title.includes("Gremory")) {
    $("#master").addClass("show");
}