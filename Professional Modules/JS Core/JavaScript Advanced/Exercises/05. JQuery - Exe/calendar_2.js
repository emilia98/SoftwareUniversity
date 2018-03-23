function calendar(date){
    let day = parseInt(date[0]);
    let month = parseInt(date[1]);
    let year = parseInt(date[2]);

    let months = ["January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"];
    let totalDaysInMonth = new Date(year, month, 0).getDate();
    // Get the first day of the month as digit [0 - 6] or when is the month starting (as day of week)
    let firstDay = new Date(year, month - 1, 1).getDay();
    // Get the name of month (for <caption>
    let nameOfMonth = months[month - 1];

    /*
     We need all the indexes to be from 1 to 7 (inclusive), so as the index of Sunday is 0 adn the week will start from Monday, we'll take the Sunday as 7, not 0
    */
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

    // Weeks could be only 4 or 5, so it could cause problems
    // We could have 6 weeks, of course incompleted (example April 2018)
    let weeks = Math.ceil(totalDaysInMonth / 7);
    let row = $('<tr>');
    let currentDay = 1;

    // For the first week, which could have empty cells
    for(let dayIndex = 1; dayIndex <= Math.max(firstDay, 7); dayIndex++){
        if(dayIndex < firstDay){
            row.append('<td></td>');
        }else{
            if(currentDay === day){
                row.append(`<td class="today">${currentDay}</td>`);
            }else{
                row.append(`<td>${currentDay}</td>`);
            }
            currentDay++;
        }
    }

    tbody.append(row);

    // Without this statement we will not catch the case with
    // 6 weeks
    if((currentDay + (weeks - 1) * 7) <= totalDaysInMonth){
        weeks++;
    }

    // For each week, without the first one and the last one
    for(let week = 2; week < weeks; week++){
        row = $('<tr>');
        for(let dayIndex = 1; dayIndex <= 7; dayIndex++){
            if(currentDay === day){
                row.append(`<td class="today">${currentDay}</td>`);
            }else{
                row.append(`<td>${currentDay}</td>`);
            }
            currentDay++;
        }
        tbody.append(row);
    }

    /*
        If we have not completed all the weeks with 7 days and we
        have some days left to be filled, we will do as we have done
        for the first week - fill the last table row with numbers (at least one number) and we will have some cells left empty
    */
    if(currentDay <= totalDaysInMonth){
        row = $('<tr>');
        for(let dayIndex = 1; dayIndex <= 7; dayIndex++){
            if(currentDay > totalDaysInMonth){
                row.append('<td></td>');
            }else{
                if(currentDay === day){
                    row.append(`<td class="today">${currentDay}</td>`);
                }else{
                    row.append(`<td>${currentDay}</td>`);
                }
            }
            currentDay++;
        }
        tbody.append(row);
    }

    calendar.append(caption);
    calendar.append(tbody);

    $('#content').append(calendar);
}