package com.example.demo.controllers;

import com.example.demo.db.UserDB;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;

@Controller
public class HomeController {
    private UserDB userDb = UserDB.getInstance();
    @GetMapping("/")
    public String home(Model model){
        model.addAttribute("username", "Guest");
        return "home";
    }
}
