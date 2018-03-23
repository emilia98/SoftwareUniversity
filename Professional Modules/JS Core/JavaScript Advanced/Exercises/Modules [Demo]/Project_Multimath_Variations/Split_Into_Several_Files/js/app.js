// Initialize

// add click handler to the start game button
document.getElementById('startGame').addEventListener('click', function () {
    setName(document.getElementById('playername').value); // player.
    printGame(); // game.
});

// add click handler to the calculate score button
document.getElementById('calculate').addEventListener('click', function () {
    calculateScore(); // game.
});

// set the default number of problems
document.getElementById('problemCount').value = getProblemCount(); // game.