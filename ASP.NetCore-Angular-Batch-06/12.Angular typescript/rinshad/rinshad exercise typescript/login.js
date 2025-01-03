var Registration = /** @class */ (function () {
    function Registration(name, status) {
        this.name = name;
        this.status = status;
    }
    return Registration;
}());
var Program = /** @class */ (function () {
    function Program() {
        this.jobProviders = ["Aitrich", "Google", "SalesNrich"];
        this.registrations = [
            new Registration("Rinshad", "pending"),
            new Registration("Jisni Parveen", "on-hold"),
            new Registration("Ruaa Aroush", "candidate"),
        ];
    }
    Program.prototype.displayMenu = function () {
        console.log("\n  Options:\n  1. Job Providers List\n  2. New Registrations\n  3. New Registrations - Pending\n  4. New Registrations - On-Hold\n  5. New Registrations - Candidate\n  6. Exit\n      ");
    };
    Program.prototype.showJobProviders = function () {
        console.log("\nJob Providers List:");
        this.jobProviders.forEach(function (provider) {
            console.log("- " + provider);
        });
    };
    Program.prototype.showNewRegistrations = function () {
        console.log("\nNew Registrations:");
        this.registrations.forEach(function (registration) {
            console.log("- " + registration.name);
        });
    };
    Program.prototype.showNewRegistrationsByStatus = function (status) {
        console.log("\nNew Registrations - ".concat(status.charAt(0).toUpperCase() + status.slice(1), ":"));
        this.registrations.forEach(function (registration) {
            if (registration.status === status) {
                console.log("- " + registration.name);
            }
        });
    };
    Program.prototype.run = function () {
        var _this = this;
        var readline = require("readline").createInterface({
            input: process.stdin,
            output: process.stdout,
        });
        var askUser = function () {
            _this.displayMenu();
            readline.question("Enter your choice (1-6): ", function (choice) {
                if (choice === "1") {
                    _this.showJobProviders();
                    askUser();
                }
                else if (choice === "2") {
                    _this.showNewRegistrations();
                    askUser();
                }
                else if (choice === "3") {
                    _this.showNewRegistrationsByStatus("pending");
                    askUser();
                }
                else if (choice === "4") {
                    _this.showNewRegistrationsByStatus("on-hold");
                    askUser();
                }
                else if (choice === "5") {
                    _this.showNewRegistrationsByStatus("candidate");
                    askUser();
                }
                else if (choice === "6") {
                    // Exit the program
                    console.log("Exiting the program. Goodbye see you next time!");
                    readline.close();
                }
            });
        };
        readline.question("Enter your username: ", function (username) {
            readline.question("Enter your password: ", function (password) {
                // Perform authentication logic here (dummy check for demo purposes)
                if (username === "admin" && password === "admin123") {
                    console.log("Login successful!");
                    askUser();
                }
                else {
                    console.log("Login failed. Please check your username and password.");
                    readline.close();
                }
            });
        });
    };
    return Program;
}());
var program = new Program();
program.run();
