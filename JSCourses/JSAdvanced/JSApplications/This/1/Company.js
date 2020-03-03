class Company {
    departments = [];
    EmployeeClass = class Employee {
        constructor(username, salary, position, department) {
            this.username = username.toString();
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
        let employee = new this.EmployeeClass(username, salary, position, department);

        this.departments.push(employee);
    }

    bestDepartment() {
        this.departments = this.departments.sort(this.sortDepartments);
        let highestAvg = 0;
        let bestDepartmentName;
        let index = 0;
        while (index !== this.departments.length) {
            let currentDepartmentName = this.departments[index].department;
            let currentDepartments = this.departments.filter(empl => empl.department === currentDepartmentName);

            let currentCount = currentDepartments.length;
            let currentSum = currentDepartments.reduce((a, b) => a + b.salary, 0);
            let currentAvg = currentSum / currentCount;
            if (highestAvg < currentAvg) {
                highestAvg = currentAvg;
                bestDepartmentName = currentDepartmentName;
            }
            index = this.departments.map(el => el.department).lastIndexOf(currentDepartmentName) + 1;
        }
        //TODO
        /** " Best Department is: {best department's name}
         Average salary: {best department's average salary}
         {employee1} {salary} {position}
         {employee2} {salary} {position}
         {employee3} {salary} {position} **/
    }

    sortDepartments(employee1, employee2) {
        if (employee1.department !== employee2.department) {
            return employee1.department.localeCompare(employee2.department);
        }

        if (employee1.salary !== employee2.salary) {
            return employee2.salary - employee1.salary;
        }

        return employee1.username.localeCompare(employee2.username);
    }
}

let c = new Company();
c.addEmployee("Stanimir", 2000, "engineer", "Construction");
c.addEmployee("Pesho", 1500, "electrical engineer", "Construction");
c.addEmployee("Slavi", 500, "dyer", "Construction");
c.addEmployee("Stan", 2000, "architect", "Construction");
c.addEmployee("Stanimir", 1200, "digital marketing manager", "Marketing");
c.addEmployee("Pesho", 1000, "graphical designer", "Marketing");
c.addEmployee("Gosho", 1350, "HR", "Human resources");
console.log(c.bestDepartment());