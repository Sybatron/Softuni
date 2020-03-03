function result(ticketsDescriptions, sortCriteria) {
    class Ticket {
        constructor(destination, price, status) {
            this.destination = destination;
            this.price = Number(price);
            this.status = status;
        }
    }

    let tickets = [];
    for (let i = 0; i < ticketsDescriptions.length; i++) {
        let currentTicket = ticketsDescriptions[i].split('|');
        tickets.push(new Ticket(currentTicket[0], currentTicket[1], currentTicket[2]));
    }

    function sortF(obj1, obj2) {
        if(sortCriteria==='price'){
            return obj1[sortCriteria]-obj2[sortCriteria];
        }
        return obj1[sortCriteria].toString().localeCompare(obj2[sortCriteria].toString());
    }
    tickets.sort(sortF);

    return tickets;
}

result(['Philadelphia|94.20|available',
        'New York City|95.99|available',
        'New York City|95.99|sold',
        'Boston|126.20|departed'
    ],
    'price'
);