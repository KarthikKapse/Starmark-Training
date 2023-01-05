class Employee{
    constructor(id,name,address){
        this.empid=id;
        this.empname=name;
        this.empaddr=address;
    }
}

class EmpRepo{
    //create an Aray Object
    data =[];

    addEmployee(emp){
        //use the this operator to access the fields of the class use the push method to add
       this.data.push(emp);
    }
    getAllEmployees() {
       return this.data;
    }
    
    getEmployee(id){
        for(const emp of this.data){
            if(emp.empid==id){
                return emp
            }
        }
        throw `Employee by ID ${id} is Not Found`;
    }

    // deleteEmployee(id){
    //     for(const emp of this.data){
    //         if(emp.empid==id){
    //             this.data.pop(this.emp);
    //         }
    //     }
    //     throw `Employee by ID ${id} is Not Found`;
    // }

    updateEmployee(emp){
        for (const empRec of this.data) {
            if(emp.empid==empRec.empid){
                empRec.empname=emp.empname;
                empRec.empaddr=emp.empaddr;
                return;
            }
        }
        throw "Employee Not Found To Update"
    }
}


// Testing
let instance= new EmpRepo();
instance.addEmployee(new Employee(6, "Karthik", "Kapse"));
instance.addEmployee(new Employee(10, "Sachin", "Tenduakar"));
instance.addEmployee(new Employee(18, "Virat", "Kohli"));
instance.addEmployee(new Employee(45, "Rohith", "sharma"));

const data= instance.getAllEmployees();
for(const emp of data) {
    console.log(emp.empid, emp.empname, emp.empaddr);
}