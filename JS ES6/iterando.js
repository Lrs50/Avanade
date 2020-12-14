let exp=[1,2,3,4,5,6,7,8,9,10];

exp.forEach((num,index) =>console.log(num,index))
console.log(exp.map(value => value*2))
console.log(exp.filter(value => value % 2 ==0))
console.log(exp.reduce((total,value)=>total+=value,0))