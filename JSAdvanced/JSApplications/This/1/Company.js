class Company {
    departments = [];
    Employee = class EmployeeClass {
        constructor(username, salary, position, department) {
            this.username = username;
            this.salary = salary;
            this.position = position;
            this.department = department;
        }
    }
    addEmployee(username, salary, position, department) {
        if ([username, salary, position, department].filter(el => el === '' || el === undefined || el === null).length !== 0) {
            throw Error("Invalid input!");
        }
        if (salary < 0) {
            throw Error("Invalid input!");
        }
        let employee = new this.Employee();
    }
}