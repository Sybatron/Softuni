class CheckingAccount {
    set clientId(value) {
        try {
            let id = parseInt(value);
            if (id / 1000000 !== 0) {
                throw new error;
            }
            this.clientId = id;
        } catch (error) {
            throw new TypeError('Client ID must be a 6-digit number');
        }
    }

    set email(value) {
        let isEmail = value.match(/\w{1,}@[A-Za-z.]{1,}/);
        if (isEmail) {
            this.email = value;
        } else {
            throw new TypeError('Invalid e-mail');
        }
    }

    set firstName(value){
        this.name('First',value);
    }

    set lastName(value){
        this.name('Last',value);
    }

    name(type,value) {
        if (value.lenght>=3 && value.lenght<=20) {
            throw new TypeError(`${type} name must be between 3 and 20 characters long`);
        }
        if(!value.match('[A-Za-z]{3,20}')){
            throw new TypeError(`${type} name must contain only Latin characters`);
        }
    }

    constructor(clientId,email,firstName,lastName) {
        this.clientId=clientId;
        this.email=email;
        this.firstName=firstName;
        this.lastName=lastName;
    }
}

let acc = new CheckingAccount('1314', 'ivan@some.com', 'Ivan', 'Petrov')