function ITsEVEN(nums){
let sum=0
for(let i=0;i<nums.length;i++){
    if(i%2==0){
        sum=+i;
    }
}
return sum;
}
console.log(ITsEVEN([1,2,3,4]))
function ItsOdd(nums){
    let sum=0
    for(let i=0;i<nums.length;i++){
        if(i%2==1){
            sum=+i;
        }
    }
    return sum;
    }
    console.log(ITsEVEN([1,2,3,4]))
    