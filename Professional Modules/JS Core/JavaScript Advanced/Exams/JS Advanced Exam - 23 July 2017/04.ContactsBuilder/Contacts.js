// THE PROBLEMS WERE:
// - we should consider the value of online property , when rendering
//   the contact
// - RETEST your solution
// - We should use element.css("display") to check if the element is
//   shown or hidden. NOT :visible
class Contact{
    constructor(firstName, lastName, phone, email){
        this.firstName = firstName;
        this.lastName = lastName;
        this.phone = phone;
        this.email = email;
        this.online = false;
    }

    get online(){
        return this._online;
    }

    set online(value){
        this._online = value;

        if(this.html){
            let divTitle = $(this.html).find(".title");

            if(value){
                divTitle.addClass("online")
            }else{
                divTitle.removeClass("online");
            }
        }
    }

    render(id) {
        let container = $(`#${id}`);

        let article = $('<article>');
        let divTitle = $('<div class="title"></div>');
        let divInfo = $('<div class="info"></div>');

        // PROBLEM #1
        if(this.online){
            divTitle.addClass("online");
        }

        divTitle.text(`${this.firstName} ${this.lastName}`);
        divTitle.append($('<button>&#8505;</button>').click(showInfo));

        divInfo.append(`<span>&phone; ${this.phone}</span>`);
        divInfo.append(`<span>&#9993; ${this.email}</span>`);

        article.append(divTitle)
            .append(divInfo);

        // PROBLEM #2
        divInfo.hide();
        article.appendTo(container);
        this.html = article;

        function showInfo() {
            let divToShow = $(this).parent().next();

            // PROBLEM #3
            if($(divToShow).css("display") === "block"){
                divToShow.hide();
            }else{
                divToShow.show();
            }
        }
    }
}


let contacts = [
    new Contact("Ivan", "Ivanov", "0888 123 456", "i.ivanov@gmail.com"),
    new Contact("Maria", "Petrova", "0899 987 654", "mar4eto@abv.bg"),
    new Contact("Jordan", "Kirov", "0988 456 789", "jordk@gmail.com")
];
contacts.forEach(c => c.render('main'));

// After 1 second, change the online status to true
setTimeout(() => contacts[1].online = true, 2000);

setTimeout(() => contacts[2].online = true, 2000);
setTimeout(() => contacts[1].online = false, 4000);
