"use strict";
// import * as nameline from "nameline";
Object.defineProperty(exports, "__esModule", { value: true });
// const answer = await nameline.prompt([    
//     {
//     type: 'input',
//     name: 'name',
//     message: 'What is your name?'
//     },
//     { 
//     type: 'number',
//     name: 'age',
//     message: 'Enter your age: '
//     },
//     {
//         type: 'list',
//         name: 'gender',
//         message: 'What is your gender?',
//         choices: ['Male', 'Female', 'Prefer not to say']
//     }
// ]);
// console.log("Your name is " + answer.name+", your age is " + answer.age + ". Your gender is " + answer.gender);
var readline = require("readline");
var rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout,
});
rl.question("What is your password ?", function (password) {
    console.log("Your password - " + password);
    rl.close();
});
