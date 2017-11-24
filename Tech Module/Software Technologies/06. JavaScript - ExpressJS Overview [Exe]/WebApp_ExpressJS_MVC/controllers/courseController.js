module.exports = {
    courseGet: (req, res) => {
        let currentCourseId = +req.params.courseId;
        res.send(`<p>This is course with id <span style="color: red">${currentCourseId} </span>.`);
    }
};