const Task = require('../models/Task');

module.exports = {
    index: (req, res) => {
    	Task.find().then( tasks => {
            	res.render('task/index', {'tasks': tasks});
			});
    },
	createGet: (req, res) => {
    	res.render('task/create');
	},
	createPost: (req, res) => {
    	if( !(req.body.title && req.body.comments)){
			//console.log(req.body);
    		return res.render('task/create', {
    			error: "Invalid data!",
				task: req.body
			});
		}

		Task.create({
			title: req.body.title,
			comments: req.body.comments
		}).then(
			task => {
				res.redirect("/");
			});
	},
	deleteGet: (req, res) => {
        Task.findById(req.params.id).then(
        	task => {
        		res.render('task/delete', task)
        	}).catch(err => {
        		console.log(err);
        		return res.redirect('/');
		});
	},
	deletePost: (req, res) => {
    	Task.findByIdAndRemove(req.params.id).then(
    		task => {
    			res.redirect('/')
			}).catch( err => {
                console.log(err);
                return res.redirect('/')
			});
	}
};