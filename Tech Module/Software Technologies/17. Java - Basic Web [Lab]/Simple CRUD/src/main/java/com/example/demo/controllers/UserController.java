package com.example.demo.controllers;

import com.example.demo.db.UserDB;
import com.example.demo.models.entity.User;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestParam;

import java.util.List;

@Controller
public class UserController {
    private UserDB userDb = UserDB.getInstance();

    @GetMapping("/create")
    public String create(Model model){
        model.addAttribute("username", "Guest");
        return "create";
    }

    @PostMapping("/create")
    public String createProcess(@RequestParam("firstName") String firstName,
                                @RequestParam("lastName") String lastName,
                                @RequestParam("age") Integer age) {
        User user = new User();
        user.setFirstName(firstName);
        user.setLastName(lastName);
        user.setAge(age);

        this.userDb.save(user);
        return "redirect:/";
    }

    @GetMapping("/allUsers")
    public String ShowAllUsers(Model model){
        List<User> allUsers = this.userDb.findAll();
        model.addAttribute("username", "Guest");
        model.addAttribute("allUsers", allUsers);
        return "allUsers";
    }

    @GetMapping("/read")
    public String getUser(@RequestParam("id") Integer id,
                          Model model){
        User user = this.userDb.getById(id);
        model.addAttribute("username", "Guest");
        model.addAttribute("user", user);
        return "singleUser";
    }

    @GetMapping("/update")
    public String update(@RequestParam("id") Integer id,
                          Model model){
        User user = this.userDb.getById(id);
        model.addAttribute("username", "Guest");
        model.addAttribute("user", user);
        return "update";
    }

    @PostMapping("/update")
    public String updateProcess(User user, Model model){
        model.addAttribute("username", "Guest");
        this.userDb.update(user);
        return "redirect:allUsers";
    }

    @PostMapping("/delete")
    public String delete(@RequestParam("id") Integer id){
        this.userDb.delete(id);
        return "redirect:allUsers";
    }
}
