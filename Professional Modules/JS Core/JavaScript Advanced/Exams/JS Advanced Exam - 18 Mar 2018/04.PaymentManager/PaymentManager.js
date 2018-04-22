class PaymentManager{
    constructor(title){
        this.title = title;
    }

    render(id){
        let container = $(`#${id}`);

        let table = $('<table>');
        let thead = $('<thead>');
        let tbody = $('<tbody class="payments"></tbody>');
        let tfoot = $('<tfoot class="input-data"></tfoot>');

        table.append(`<caption>${this.title} Payment Manager</caption>`);

        thead.append(
            $('<tr>')
                .append($('<th class="name">Name</th>'))
                .append($('<th class="category">Category</th>'))
                .append($('<th class="price">Price</th>'))
                .append($('<th>Actions</th>'))
        );

        let addBtn = $('<button>Add</button>').click(addPayment);

        tfoot.append(
            $('<tr>')
                .append($('<td><input name="name" type="text"></td>'))
                .append($('<td><input name="category" type="text"></td>'))
                .append($('<td><input name="price" type="number"></td>'))
                .append($('<td></td>').append(addBtn))
        );

        table.append(thead)
            .append(tbody)
            .append(tfoot);
        table.appendTo(container);

        function addPayment(){
            let inputFields = $(this).parent().parent().find("input");
            let nameInput = $(inputFields[0]);
            let categoryInput = $(inputFields[1]);
            let priceInput = $(inputFields[2]);

            if(nameInput.val().length === 0 || categoryInput.val().length === 0 || priceInput.val().length === 0){
                return 0;
            }
            
            let paymentRow = $('<tr>');
            let deleteBtn = $('<button>Delete</button>').click(deleteRow);
            
            paymentRow.append($(`<td>${nameInput.val()}</td>`))
                .append($(`<td>${categoryInput.val()}</td>`))
                .append($(`<td>${Math.round(priceInput.val() * 100000) / 100000}</td>`))
                .append($(`<td></td>`).append(deleteBtn));

            paymentRow.appendTo(tbody);

            nameInput.val("");
            categoryInput.val("");
            priceInput.val("");
        }
        
        function deleteRow(){
            $(this).parent().parent().remove();
        }
    }
}