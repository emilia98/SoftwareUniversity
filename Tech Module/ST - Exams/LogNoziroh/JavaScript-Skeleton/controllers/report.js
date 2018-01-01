const Report = require('../models/Report');

module.exports = {
    index: (req, res) => {
        Report.find().then(reports => {
            return res.render(
                'report/index', {'reports': reports});
        });
    },
    createGet: (req, res) => {
        return res.render('report/create');
    },
    createPost: (req, res) => {
        let report = req.body;

        if( !(report.message && report.origin)) {
            return res.render('report/create', {
                error: "Invalid data!",
                "report": report
            });
        }

        Report.create({
            status: report.status,
            message: report.message,
            origin: report.origin,
        }).then(
            report => {
                res.redirect("/");
            });
    },
    detailsGet: (req, res) => {
        let reportId = req.params.id;

        Report.findById(reportId).then(
            report => {
                if(report){
                    return res.render('report/details', report);
                }
                else{
                    return res.redirect('/');
                }
            }).catch(err => res.redirect('/'));
    },
    deleteGet: (req, res) => {
        let reportId = req.params.id;

        Report.findById(reportId).then(
            report => {
                if(report){
                    return res.render('report/delete', report);
                }
                else{
                    return res.redirect('/');
                }
            }).catch(err => res.redirect('/'));
    },
    deletePost: (req, res) => {
        let reportId = req.params.id;

        Report.findByIdAndRemove(reportId)
            .then(report => {
                res.redirect("/");
            }).catch(err => res.redirect('/'));
    }
};