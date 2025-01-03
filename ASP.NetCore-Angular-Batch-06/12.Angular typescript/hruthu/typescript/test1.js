"use strict";
// import * as readline from 'readline';
Object.defineProperty(exports, "__esModule", { value: true });
// enum Command {
//     Register,
//     Login,
//     Logout,
//   }
//   function register(username: string, password: string) {
//   }
//   function login(username: string, password: string) {
//   }
//   function logout() {
//   }
//   function main() {
//     const command = process.argv[2];
//     switch (command) {
//       case Command.Register:
//         const username = process.argv[3];
//         const password = process.argv[4];
//         register(username, password);
//         break;
//       case Command.Login:
//         const username = process.argv[3];
//         const password = process.argv[4];
//         login(username, password);
//         break;
//       case Command.Logout:
//         logout();
//         break;
//       default:
//         console.log("Invalid command.");
//     }
//   }
//   main();
var readline = require("readline");
var rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout,
});
console.log("1. Register 2. Login 3. Exit");
rl.question("Choose any ", function (id) {
    var details = [
        { User: "Hruthu", Password: 1234 }
    ];
    var di = id;
    switch (id) {
        case '1':
            rl.question("User: ", function (name) {
                rl.question("Password : ", function (passord) {
                    if (name == "" && passord == "" || name == null && passord == null) {
                        console.log("Invalid name or password ");
                        rl.close();
                    }
                    else {
                        details.push({ User: name, Password: passord });
                        console.log(details);
                        rl.close();
                    }
                });
            });
        case '2':
            rl.question("User: ", function (name) {
                rl.question("Password: ", function (password) {
                    if (name == details[0].User && password == details[0].Password) {
                        console.log("Hello," + name);
                        rl.close();
                    }
                    else {
                        console.log("Invalid name or password ");
                        rl.close();
                    }
                });
            });
        case '3':
            rl.question('Is this example useful? [y/n]', function (answer) {
                switch (answer.toLowerCase()) {
                    case 'y':
                        console.log('Successfully Signout');
                        break;
                    case 'n':
                        console.log("Welcome Back");
                        break;
                    default:
                        console.log('Invalid answer!');
                }
                rl.close();
            });
        default:
    }
});
