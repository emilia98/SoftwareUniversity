const Anime = require('../models/Anime');

module.exports = {
	index: (req, res) => {
		Anime.find().then( animes => {
            return res.render(
                'anime/index', {'animes': animes});
		});
	},
	createGet: (req, res) => {
        return res.render('anime/create');
	},
	createPost: (req, res) => {
		let anime = req.body;

        if( !(anime.rating && anime.name && anime.description)){
            return res.render('anime/create', {
                error: "Invalid data!",
                "anime": anime
            });
        }

        Anime.create({
			rating: anime.rating,
            name: anime.name,
            description: anime.description,
            watched: anime.watched
        }).then(
            anime => {
                res.redirect("/");
            });
	},
	deleteGet: (req, res) => {
        let animeId = req.params.id;

        Anime.findById(animeId).then(
            anime => {
                if(anime){
                    return res.render('anime/delete', anime);
                }
                else{
                    return res.redirect('/');
                }
            }).catch(err => res.redirect('/'));
	},
	deletePost: (req, res) => {
        let animeId = req.params.id;

        Anime.findByIdAndRemove(animeId)
            .then(anime => {
                res.redirect("/");
            }).catch(err => res.redirect('/'));
	}
};