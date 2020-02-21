class ChristmasDinner {
    dishes = [];
    products = [];
    guests = {};

    constructor(budget) {
        this.budget = budget;
    }

    get budget(){
        return this._budget;
    }
    set budget(value){
        if(value<0){
            throw Error('The budget cannot be a negative number');
        }
        this._budget=value;
    }

    shopping(product) {
        if(this.budget - product[1] < 0){
            throw Error("Not enough money to buy this product");
        }
        this.budget-=product[1];
        this.products.push(product[0]);

        console.log(`You have successfully bought ${product[0]}!`)
    }

    recipes(recipe){
        for (const product of recipe.productsList) {
            if(!this.products.includes(product)){
                throw Error("We do not have this product");
            }
        }

        this.dishes.push(recipe);
        console.log(`${recipe.recipeName} has been successfully cooked!`);
    }

    inviteGuests(name,dish){
        if(!this.dishes.filter(el=>el.recipeName===dish)){
            throw Error("We do not have this dish");
        }
        if(this.guests.hasOwnProperty(name)){
            throw Error("This guest has already been invited");
        }

        let dishObj = this.dishes.filter(el=>el.recipeName===dish)[0];
        this.guests[name]=dishObj;
        console.log(`You have successfully invited ${name}!`);
    }
    showAttendance(){
        let result='';
        for (const guest in this.guests) {
            if (this.guests.hasOwnProperty(guest)) {
                const element = this.guests[guest];
               result+=`${guest} will eat ${element.recipeName}, which consists of ${element.productsList.join(', ')}\n`;
            }
        }
        return result.trim();
    }
}

let dinner = new ChristmasDinner(300);

dinner.shopping(['Salt', 1]);
dinner.shopping(['Beans', 3]);
dinner.shopping(['Cabbage', 4]);
dinner.shopping(['Rice', 2]);
dinner.shopping(['Savory', 1]);
dinner.shopping(['Peppers', 1]);
dinner.shopping(['Fruits', 40]);
dinner.shopping(['Honey', 10]);

dinner.recipes({
    recipeName: 'Oshav',
    productsList: ['Fruits', 'Honey']
});
dinner.recipes({
    recipeName: 'Folded cabbage leaves filled with rice',
    productsList: ['Cabbage', 'Rice', 'Salt', 'Savory']
});
dinner.recipes({
    recipeName: 'Peppers filled with beans',
    productsList: ['Beans', 'Peppers', 'Salt']
});

dinner.inviteGuests('Ivan', 'Oshav');
dinner.inviteGuests('Petar', 'Folded cabbage leaves filled with rice');
dinner.inviteGuests('Georgi', 'Peppers filled with beans');

console.log(dinner.showAttendance());
