define(['./player', './game'], function (_player, _game) {
    'use strict';

    var player = _interopRequireWildcard(_player);

    var game = _interopRequireWildcard(_game);

    function _interopRequireWildcard(obj) {
        if (obj && obj.__esModule) {
            return obj;
        } else {
            var newObj = {};

            if (obj != null) {
                for (var key in obj) {
                    if (Object.prototype.hasOwnProperty.call(obj, key)) newObj[key] = obj[key];
                }
            }

            newObj.default = obj;
            return newObj;
        }
    }

    // add click handler to the start game button
    document.getElementById('startGame').addEventListener('click', function () {
        player.setName(document.getElementById('playername').value); // player.
        game.printGame(); // game.
    });

    // add click handler to the calculate score button
    document.getElementById('calculate').addEventListener('click', function () {
        game.calculateScore(); // game.
    });

    // set the default number of problems
    document.getElementById('problemCount').value = game.getProblemCount(); // game.
});
//# sourceMappingURL=app.js.map