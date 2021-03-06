package teistermask.controller;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.validation.BindingResult;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import teistermask.bindingModel.TaskBindingModel;
import teistermask.entity.Task;
import teistermask.repository.TaskRepository;

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
		List<Task> openTasks = this.taskRepository.findAllByStatus("Open");
		List<Task> inProgressTasks = this.taskRepository.findAllByStatus("In Progress");
		List<Task> finishedTasks = this.taskRepository.findAllByStatus("Finished");

		model.addAttribute("openTasks", openTasks);
		model.addAttribute("inProgressTasks", inProgressTasks);
		model.addAttribute("finishedTasks", finishedTasks);
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
		task.setStatus(taskBindingModel.getStatus());

		this.taskRepository.saveAndFlush(task);
		return "redirect:/";
	}

	@GetMapping("/edit/{id}")
	public String edit(Model model, @PathVariable Integer id) {

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
		model.addAttribute("view", "task/edit");
		return "base-layout";
	}

	@PostMapping("/edit/{id}")
	public String editProcess(Model model,
							  @PathVariable Integer id,
							  @Valid TaskBindingModel taskBindingModel,
							  BindingResult bindingResult) {
		if(id == null){
			model.addAttribute("view", "not-found");
			return "base-layout";
		}

		// If there is at least one error in the form,
		// send a message for invalid data and return again on the create page

		if(bindingResult.hasErrors()){
			model.addAttribute("message", "Invalid data!");
			model.addAttribute("task", taskBindingModel);
			model.addAttribute("view", "task/edit");
			return "base-layout";
		}

		Task taskFromDb = this.taskRepository.findOne(id);

		if(taskFromDb == null){
			model.addAttribute("view", "not-found");
			return "base-layout";
		}

		taskFromDb.setTitle(taskBindingModel.getTitle());
		taskFromDb.setStatus(taskBindingModel.getStatus());

		this.taskRepository.saveAndFlush(taskFromDb);
		return "redirect:/";
	}
}
