class Student{
    constructor(name,surname,age,point){
    this.Name=name;
    this.Surname=surname;
    this.Age=age;
    this.Point=point;}
}
function checkStudentsPoint(studentsArr){
    let students =[];
    for(let index=0;index<studentsArr.length;index++){
        if(studentsArr[index].Point>50){
          students[students.length]=studentsArr[index];
        }
    }
    return students;
}
    let Student1=new Student('Roya','Sultanova',21,81);
    let Student2=new Student('Gunel','Eliyeva',17,45);
    let Student3=new Student('Seddam','Eliquliyev',21,95);
    let arr=[Student1,Student2,Student3]
    console.log(checkStudentsPoint([Student1,Student2,Student3]));




function Repeat(word,count=1){
    let newStr=""
    for(let i=0;i<count;i++){
    newStr+=word;
    }
    return newStr
}

console.log(Repeat("Ha!",2));





function ItsOdd(nums){
    let sum=0
    if(!isNaN)
    for(let i=0;i<nums.length;i++){

        if(!isNaN)
        {
            if(i%2==0){
                sum=+i;
            }

        }
        return sum;

    }  
    console.log(ItsOdd([1,2,3,4]))
}
