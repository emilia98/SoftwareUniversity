const Task = require('../models/Task');

module.exports = {
	index: (req, res) => {
		Task.find().then( tasks => {
			let openTasks = [];
			let inProgressTasks = [];
			let finishedTasks = [];

			for(let task of tasks){
				if(task.status === "Open"){
					openTasks.push(task);
				} else if(task.status === "In Progress"){
					inProgressTasks.push(task);
				} else if(task.status === "Finished"){
					finishedTasks.push(task);
				}
			}

			res.render("task/index",  {	"openTasks": openTasks,
					"inProgressTasks": inProgressTasks,
					"finishedTasks": finishedTasks});
			});
	},
	createGet: (req, res) => {
        res.render('task/create');
	},
	createPost: (req, res) => {
        if( !req.body.title){
            //console.log(req.body);
            return res.render('task/create', {
                error: "Invalid data!",
                task: req.body
            });
        }

        Task.create({
            title: req.body.title,
            status: req.body.status
        }).then(
            task => {
                res.redirect("/");
            });
	},
	editGet: (req, res) => {
        let taskId = req.params.id;

        Task.findById(taskId).then(
            task => {
                if(task){
                    res.render("task/edit",
                        {"task" : task});
                }
                else{
                    res.redirect("/");
                }
            }).catch(err => res.redirect("/"));
	},
	editPost: (req, res) => {
        let taskId = req.params.id;
        let task = req.body;


        if(!req.body.title){
            return res.render('task/edit', {
                error: "Invalid data!",
                task: req.body
            });
        }

        Task.findByIdAndUpdate(
            taskId, task)
			.then(
                task => {
                    res.redirect("/")
                });
	}
};