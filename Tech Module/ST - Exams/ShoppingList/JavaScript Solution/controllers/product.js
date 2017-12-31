const Product = require('../models/Product');

module.exports = {
	index: (req, res) => {
		Product.find().then( products => {
			res.render('product/index', { 'entries': products})
		});
    	},
	createGet: (req, res) => {
		res.render('product/create');
	},
	createPost: (req, res) => {
		let enteredProduct = req.body;

        if( !(enteredProduct.name && enteredProduct.quantity && enteredProduct.priority)){
            return res.render('product/create', {
                error: "Invalid data!",
                product: req.body
            });
        }
		Product.create({
            priority: enteredProduct.priority,
            name: enteredProduct.name,
            quantity: enteredProduct.quantity,
            status: enteredProduct.status,
		}).then(
        	product => {
        	    res.redirect("/");
        	}
		);
	},
	editGet: (req, res) => {
        let productId = req.params.id;

        Product.findById(productId).then(
            product => {
                if(product){
                    res.render("product/edit", {
                        "product" : product
                    });
                }
                else{
                    res.redirect("/");
                }
            }).catch(err => res.redirect("/"));
	},
	editPost: (req, res) => {
        let productId = req.params.id;
        let product = req.body;


        if(!req.body.name || !req.body.priority || !req.body.quantity){
            return res.render('product/edit', {
                error: "Invalid data!",
                "product" : req.body
            });
        }

        Product.findByIdAndUpdate(
            productId, product)
            .then(
                prod => {
                    res.redirect("/")
                });

	}
};