let obj={};

obj.id=06;
obj.name='karthik';
obj.addr='kapse';

for(const key in obj){
    console.log(obj[key])
}
//to display in json format add JSON.stringify
console.log(JSON.stringify(obj))

class Employee{
    constructor(id,name,address){
        this.empid=id;
        this.empname=name;
        this.empaddr=address
    }
}

const empobj= new Employee(10, "Sachin", "Tendulakar");