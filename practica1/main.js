class Person{
    constructor(name,surname,age){
        this.name=name;
        this.surname=surname;
        this.age=age;
    }
    GetInfo(){
        return `name:${this.name}-surname:${this.surname}-age:${this.age}`
    }
}
class Teacher extends Person{
    constructor(name,surname,age,salary){
        super(name,surname,age);
            this.salary=salary;
    }
   
    }   


class Department{
    constructor(name){
        this.name=name;
    }
    Teachers=[];
    Add(teacher1){
        this.Teachers.push(teacher1)
    }
    SearchTeacherByName(search1){
        return this.Teachers.filter(element =>element.name.includes(search1/i));
            
    }
    GetTeacherSalaryAvg(){
        let total=0;
        this.Teachers.forEach(x=>total+=x.salary)
        return total/this.Teachers.length
    }
}
let departmentname=prompt("Dp Name")
let department=new Department(departmentname)
let check=true;
do{
    search1=prompt("Enter Search");
    switch(search1){


        case "Add":
         let eName=prompt("Ad daxil edin")
         let surname=prompt("Soyad daxil edin") 
         let age=prompt("Yas daxil edin")

         while (isNaN (age)) {
            age=prompt("Duzgun daxil edin")
         }
         let salary=prompt("Maas daxil edin")
         while(isNaN(salary)){
             salary=prompt("Duzgun daxil edin")
         };
        let tchr=new Teacher(eName,surname,age,salary)
        department.Add(tchr);
        break;

        case "q":
        check=false;
        break;
    }
}
while(check)
console.log(department.Teachers)