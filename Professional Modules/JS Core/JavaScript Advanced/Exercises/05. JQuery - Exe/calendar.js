function calendar(date){
    let day = parseInt(date[0]);
    let month = parseInt(date[1]);
    let year = parseInt(date[2]);

    let months = ["January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"];
    let totalDaysInMonth = new Date(year, month, 0).getDate();
    let firstDay = new Date(year, month - 1, 1).getDay();
    let nameOfMonth = months[month - 1];

    if(firstDay === 0){
        firstDay = 7;
    }

    let calendar = $("<table>");
    let caption = $(`<caption>${nameOfMonth} ${year}</caption>`);
    let tbody = $('<tbody>');
    let firstRow = $('<tr>').append('<th>Mon</th>')
                            .append('<th>Tue</th>')
                            .append('<th>Wed</th>')
                            .append('<th>Thu</th>')
                            .append('<th>Fri</th>')
                            .append('<th>Sat</th>')
                            .append('<th>Sun</th>');

    tbody.append(firstRow);

    let currentDay = 1;

    while(currentDay <= totalDaysInMonth){
        let row = $('<tr>');

        for(let dayIndex = 1; dayIndex <= 7; dayIndex++){
            if(dayIndex < firstDay && currentDay === 1){
                row.append('<td></td>');
                continue;
            }

            if(currentDay > totalDaysInMonth){
                row.append('<td></td>');
                continue;
            }

            if(currentDay === day){
                row.append(`<td class="today">${currentDay}</td>`);
            }else{
                row.append(`<td>${currentDay}</td>`);
            }
            currentDay++;
        }
        tbody.append(row);
    }

    calendar.append(caption);
    calendar.append(tbody);

    $('#content').append(calendar);
}