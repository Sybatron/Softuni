function htmledJSON(jsonArray) {
    class Employee{
        constructor(name,position,salary){
            this.name=name;
            this.position=position;
            this.salary=salary;
        }
    }

    let employees=[];
    jsonArray.forEach(element => {
        let el = JSON.parse(element);
        employees.push(new Employee(el.name,el.position,el.salary));
    });
    
    let result = '<table>\n';
    employees.forEach(element => {
        result+='	<tr>\n';

        for (const key in element) {
            result+=`		<td>${element[key]}</td>\n`
        }

        result+='	</tr>\n';
    });
    result+='</table>';

    console.log(result);
}

htmledJSON(['{"name":"Pesho","position":"Promenliva","salary":100000}',
'{"name":"Teo","position":"Lecturer","salary":1000}',
'{"name":"Georgi","position":"Lecturer","salary":1000}']
);