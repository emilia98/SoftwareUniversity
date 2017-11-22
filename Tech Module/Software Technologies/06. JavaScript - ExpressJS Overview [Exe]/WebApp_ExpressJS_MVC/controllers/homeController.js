module.exports = {
    homeGet: (req, res) => {
        res.render('home', {
                name: "Pesho",
                grades: [5, 4, 6, 3],
                isAdmin: true
            });
    }
};