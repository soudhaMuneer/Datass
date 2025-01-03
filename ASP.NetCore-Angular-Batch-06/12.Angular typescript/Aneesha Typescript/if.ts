const check = (a:number,b:number,c:number,itsOk:boolean):boolean=>{
    if(itsOk){
        return b<c;
    }else{
        return b>a && c>b;
    }
}
console.log(check(1,2,4,false));
console.log(check(2,1,4,true));