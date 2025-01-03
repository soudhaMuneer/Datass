const checkInteger = (a:number,b:number,c:number,itsok:boolean): boolean => {
    if(itsok){
       return b<c;
    }
    else{
        return b>a && b>c ;
    }
}

console.log(checkInteger(1,2,4,false));
console.log(checkInteger(2,1,4,true));
console.log(checkInteger(1,3,2,true));