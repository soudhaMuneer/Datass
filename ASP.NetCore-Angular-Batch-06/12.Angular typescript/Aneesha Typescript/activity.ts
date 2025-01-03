const isPossible=(a:number,b:number,c:number):boolean=>(a+b===c)||(a+c===b)||(b+c===a);
console.log(isPossible(2,3,5));
console.log(isPossible(1,5,4));


