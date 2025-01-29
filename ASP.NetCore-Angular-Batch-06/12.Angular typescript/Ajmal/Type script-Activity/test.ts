let a = 11;
let b = 12;
let c = a * b;
console.log(c);

const isPossible = (a: number, b: number, c: number): boolean => (a + b === c) || (a + c === b) || (b + c === a);
console.log(isPossible(3, 2, 5)); // true
console.log(isPossible(1, 2, 4)); // false

const message: string = "Hello, TypeScript!";
console.log(message);

const checkIntegers = (type: "input", a: number, b: number, c: number, itsOk: boolean): boolean => {
    if (itsOk) {
        return b < c;
    } else {
        return b > a && c > b;
    }
}
console.log(checkIntegers("Enter value =", 1, 2, 3, true)); // true
console.log(checkIntegers(2, 1, 4, true)); // true
console.log(checkIntegers(1, 3, 2, false)); // false
=======
console.log(checkIntegers(1, 2, 3, true)); // true
console.log(checkIntegers(2, 1, 4, true)); // true
console.log(checkIntegers(1, 3, 2, false)); // false
    if (itsOk) {
    return b < c;
    } else {
    return b > a && c > b;
    }
    }
    console.log(checkIntegers("Enter value =") );
    console.log(checkIntegers(1, 2, 3, true)); // true
    console.log(checkIntegers(2, 1, 4, true)); // true
    console.log(checkIntegers(1, 3, 2, false)); // false

    // import * as readline from 'readline';

    // const rl = readline.createInterface({
    //   input: process.stdin,
    //   output: process.stdout,
    // });
    
    // rl.question("What is your name ? ", (name) => {
    //     rl.question("What is your Password ? ", (password) => {
    //     if(name=="Hruthu" && password=="1234"){
    //         console.log("Hello," +name );
    //         rl.close();
    //     }
    //     else{
            
    //         console.log("Invalid name or password ");
    //         rl.close();
    //     }
        
    // });

    // });
    // rl.question("What is your password? ", (password) => {
      
      
    // });

    
   