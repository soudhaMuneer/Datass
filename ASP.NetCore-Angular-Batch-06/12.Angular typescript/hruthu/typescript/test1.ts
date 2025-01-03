// import * as readline from 'readline';

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

import * as readline from "readline";

const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout,
});


console.log("1. Register 2. Login 3. Exit");
rl.question("Choose any ", (id) => {
    const details: [{ User: string, Password: any }] = [
        { User: "Hruthu", Password: 1234 }
    ];
    var di = id;
    switch (id) {


        case '1':
            rl.question("User: ", (name) => {
                rl.question("Password : ", (passord) => {
                    if (name == "" && passord == "" || name == null && passord == null) {
                        console.log("Invalid name or password ");
                        rl.close();
                    }
                    else {
                        details.push({ User: name, Password: passord });
                        console.log(details);
                        rl.close();
                    }
                })
            })

            
        case '2':
            rl.question("User: ", (name) => {
                rl.question("Password: ", (password) => {
                    if (name == details[0].User && password == details[0].Password) {
                        console.log("Welcome, " + name);
                        rl.close();
                    }
                    else {

                        console.log("Invalid name or password ");

                        rl.close();
                    }
                });
            });


        case '3':
            rl.question('Is this example useful? [y/n]', (answer) => {
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
