function validate(){
    let username = $('#username');
    let email = $('#email');
    let password = $('#password');
    let confirmPassword = $('#confirm-password');
    let checkbox = $('#company');
    let companyInfo = $("#companyInfo");
    let companyNumber = $('#companyNumber');
    let submitBtn = $('#submit');
    let valid = $('#valid');

    let usernamePattern = /^[a-zA-Z0-9]{3,20}$/;
    let passwordPattern = /^[/\w]{5,15}$/;
    let emailPattern = /^([^@]+)@([^@.]*)(\.[^@.]*){1,}$/;
    let companyNumberPattern = /^[1-9][0-9]{3}$/;


    checkbox.on("change", function(){
        let isChecked = checkbox.prop("checked");

        if(isChecked){
            companyInfo.removeAttr("style");
        }else{
            companyInfo.css("display", "none");
        }
    });

    submitBtn.click(submit);

    function submit(e){
        e.preventDefault();
        let isValid = true;

        $("input").removeAttr("style");

        if(usernamePattern.test(username.val()) === false){
            isValid = false;
            username.css("border-color", "red");
        }

        if(emailPattern.test(email.val()) === false){
            isValid = false;
            email.css("border-color", "red");
        }

        if(passwordPattern.test(password.val()) === false){
            isValid = false;
            password.css("border-color", "red");
        }

        if(passwordPattern.test(confirmPassword.val()) === false){
            isValid = false;
            confirmPassword.css("border-color", "red");
        }


        if(password.val() !== confirmPassword.val()){
            isValid = false;
            password.css("border-color", "red");
            confirmPassword.css("border-color", "red");
        }

        if(checkbox.prop("checked") && !companyNumberPattern.test(companyNumber.val())){
            isValid = false;
            companyNumber.css("border-color", "red");
        }

        if(isValid){
            valid.removeAttr("style");
        }else{
            valid.css("display", "none");
        }
    }
}