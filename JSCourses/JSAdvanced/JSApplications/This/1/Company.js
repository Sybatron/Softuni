class Company {
    departments = [];
    EmployeeClass = class Employee {
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

        let employee = new this.EmployeeClass(username, salary, position, department);
        this.departments.push(employee);
        return `New employee is hired. Name: ${username}. Position: ${position}`;
    }

    bestDepartment() {
        this.departments = this.departments.sort(this.sortDepartments);
        let bestDepartmentAvg = 0;
        let bestDepartmentName;
        let index = 0;

        while (index !== this.departments.length) {
            let currentDepartmentName = this.departments[index].department;
            let currentDepartment = this.departments.filter(empl => empl.department === currentDepartmentName);

            let currentCount = currentDepartment.length;
            let currentSum = currentDepartment.reduce((a, b) => a + b.salary, 0);
            let currentAvg = currentSum / currentCount;
            if (bestDepartmentAvg < currentAvg) {
                bestDepartmentAvg = currentAvg;
                bestDepartmentName = currentDepartmentName;
            }
            index = this.departments.map(el => el.department).lastIndexOf(currentDepartmentName) + 1;
        }
        let resultText = `Best Department is: ${bestDepartmentName}\n` + `Average salary: ${bestDepartmentAvg.toFixed(2)}`;

        let bestDepartment = this.departments.filter(empl => empl.department === bestDepartmentName);

        bestDepartment.forEach(empl => {
            resultText += `\n${empl.username} ${empl.salary} ${empl.position}`;
        });

        return resultText;
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