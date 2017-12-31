package animelist.controller;

import animelist.entity.Anime;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.validation.BindingResult;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import animelist.bindingModel.AnimeBindingModel;
import animelist.repository.AnimeRepository;

import javax.validation.Valid;
import java.util.List;

@Controller
public class AnimeController {

	private final AnimeRepository animeRepository;

	@Autowired
	public AnimeController(AnimeRepository animeRepository) {
		this.animeRepository = animeRepository;
	}

	@GetMapping("/")
	public String index(Model model) {
		List<Anime> animes = animeRepository.findAll();

		model.addAttribute("animes", animes);
		model.addAttribute("view", "anime/index");
		return "base-layout";
	}

	@GetMapping("/create")
	public String create(Model model) {
		model.addAttribute("anime", new Anime());
		model.addAttribute("view", "anime/create");
		return "base-layout";
	}

	@PostMapping("/create")
	public String createProcess(Model model,
								@Valid AnimeBindingModel animeBindingModel,
								BindingResult bindingResult) {
		// If there is at least one error in the form,
		// send a message for invalid data and return again on the create page
		if(bindingResult.hasErrors()){
			model.addAttribute("message", "Invalid data!");
			model.addAttribute("anime", animeBindingModel);
			model.addAttribute("view", "anime/create");
			return "base-layout";
		}

		Anime anime = new Anime();
		anime.setRating(animeBindingModel.getRating());
		anime.setName(animeBindingModel.getName());
		anime.setDescription(animeBindingModel.getDescription());
		anime.setWatched(animeBindingModel.getWatched());
		animeRepository.saveAndFlush(anime);

		return "redirect:/";
	}

	@GetMapping("/delete/{id}")
	public String delete(Model model,
						 @PathVariable Integer id) {

		if(id == null){
			model.addAttribute("view", "not-found");
			return "base-layout";
		}

		Anime anime = animeRepository.findOne(id);

		if(anime == null){
			model.addAttribute("view", "not-found");
			return "base-layout";
		}

		model.addAttribute("anime", anime);
		model.addAttribute("view", "anime/delete");
		return "base-layout";
	}

	@PostMapping("/delete/{id}")
	public String deleteProcess(Model model,
								@PathVariable Integer id,
								AnimeBindingModel animeBindingModel) {
		Anime anime = animeRepository.findOne(id);

		if(anime == null){
			model.addAttribute("view", "not-found");
			return "base-layout";
		}

		animeRepository.delete(anime);
		animeRepository.flush();
		return "redirect:/";
	}
}
