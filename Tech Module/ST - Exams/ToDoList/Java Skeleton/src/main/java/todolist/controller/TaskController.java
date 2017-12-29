package todolist.controller;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.validation.BindingResult;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import todolist.bindingModel.TaskBindingModel;
import todolist.entity.Task;
import todolist.repository.TaskRepository;

import javax.validation.Valid;
import java.util.List;

@Controller
public class TaskController {
    private final TaskRepository taskRepository;

    @Autowired
    public TaskController(TaskRepository taskRepository) {
        this.taskRepository = taskRepository;
    }

    @GetMapping("/")
    public String index(Model model) {
        List<Task> tasks = taskRepository.findAll();
        model.addAttribute("tasks", tasks);
        model.addAttribute("view", "task/index");
        return "base-layout";
    }

    @GetMapping("/create")
    public String create(Model model) {
        model.addAttribute("task", new Task());
        model.addAttribute("view", "task/create");
        return "base-layout";
    }

    @PostMapping("/create")
    public String createProcess(Model model,
                                @Valid TaskBindingModel taskBindingModel,
                                BindingResult bindingResult) {

        // If there is at least one error in the form,
        // send a message for invalid data and return again on the create page
        if(bindingResult.hasErrors()){
            model.addAttribute("message", "Invalid data!");
            model.addAttribute("task", taskBindingModel);
            model.addAttribute("view", "task/create");
            return "base-layout";
        }

        Task task = new Task();
        task.setTitle(taskBindingModel.getTitle());
        task.setComments(taskBindingModel.getComments());
        taskRepository.saveAndFlush(task);

        return "redirect:/";
    }

    @GetMapping("/delete/{id}")
    public String delete(Model model, @PathVariable Integer id) {
        if(id == null){
            model.addAttribute("view", "not-found");
            return "base-layout";
        }

        Task task = this.taskRepository.findOne(id);

        if(task == null){
            model.addAttribute("view", "not-found");
            return "base-layout";
        }

        model.addAttribute("task", task);
        model.addAttribute("view", "task/delete");
        return "base-layout";
    }

    @PostMapping("/delete/{id}")
    public String deleteProcess(Model model, @PathVariable int id) {
        Task task = this.taskRepository.findOne(id);

        if(task == null){
            model.addAttribute("view", "not-found");
            return "base-layout";
        }

        taskRepository.delete(task);
        taskRepository.flush();

        return "redirect:/";
    }
}
