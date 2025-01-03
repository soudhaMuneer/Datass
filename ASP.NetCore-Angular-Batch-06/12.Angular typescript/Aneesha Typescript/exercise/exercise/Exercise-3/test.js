"use strict";
var __assign = (this && this.__assign) || function () {
    __assign = Object.assign || function(t) {
        for (var s, i = 1, n = arguments.length; i < n; i++) {
            s = arguments[i];
            for (var p in s) if (Object.prototype.hasOwnProperty.call(s, p))
                t[p] = s[p];
        }
        return t;
    };
    return __assign.apply(this, arguments);
};
Object.defineProperty(exports, "__esModule", { value: true });
var readline = require("readline");
var ap = [];
var view = [];
var rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});
var pass = [];
var Menu = /** @class */ (function () {
    function Menu() {
    }
    Menu.prototype.main = function () {
        var _this = this;
        console.log("1.SignUp", "\n" + "2.Login", "\n" + "3.Exit");
        rl.question("Select ", function (select) {
            switch (select) {
                case '1':
                    _this.signup();
                    break;
                case '2':
                    _this.login();
                    break;
                case '3':
                    rl.close();
                    break;
                default:
                    console.log('Invalid option');
                    break;
            }
        });
    };
    Menu.prototype.signup = function () {
        var _this = this;
        console.log("-------------------------------------------------- Signup --------------------------------------------------");
        rl.question("UserName : ", function (un) {
            rl.question("FirstName : ", function (fn) {
                rl.question("LastName : ", function (ln) {
                    rl.question("Gender : ", function (gn) {
                        rl.question("Phone : ", function (ph) {
                            rl.question("Password : ", function (pw) {
                                if (un === "" || fn === "" || ln === "" || gn === "" || ph === '' || pw === '') {
                                    console.log("Invalid input");
                                    _this.main();
                                }
                                else {
                                    var pus = {
                                        un: un,
                                        fn: fn,
                                        ln: ln,
                                        ph: ph,
                                        gn: gn,
                                        pw: pw
                                    };
                                    pass.push(pus);
                                    _this.login();
                                }
                            });
                        });
                    });
                });
            });
        });
    };
    Menu.prototype.login = function () {
        var _this = this;
        console.log("-------------------------------------------------- Login --------------------------------------------------");
        rl.question("UserName : ", function (ul) {
            rl.question("Password : ", function (pl) {
                var userFound = pass.some(function (user) { return user.un === ul && user.pw === pl; });
                if (userFound) {
                    _this.menu2();
                }
                else {
                    console.log("Invalid credentials. Please try again.");
                    _this.signup();
                }
            });
        });
    };
    Menu.prototype.menu2 = function () {
        var _this = this;
        console.log('------------------------------------------------------------------------------------------------------------\n');
        console.log("1.Jobs     2.Applied Jobs     3.Logout                                     Welcome to JobPlatform");
        rl.question("Choose", function (id) {
            switch (id) {
                case '1':
                    _this.list();
                    break;
                case '2':
                    _this.apply();
                    break;
                case '3':
                    _this.main();
                    break;
                default:
                    console.log('Invalid option');
                    break;
            }
        });
        console.log('\n------------------------------------------------------------------------------------------------------------');
    };
    Menu.prototype.list = function () {
        var _this = this;
        view.push({ JobTitle: "Python Developer", CompanyName: "Aitrich", Place: "Thrissur", mode: "Remote", Discription: "The average experience requirement of a Python developer is 3 years." }, { JobTitle: ".NET Developer", CompanyName: "Aitrich", Place: "Thrissur", mode: "Remote", Discription: "The average experience requirement of a Python developer is 3 years." }, { JobTitle: "Angular Developer", CompanyName: "Aitrich", Place: "Thrissur", mode: "Remote", Discription: "The average experience requirement of a Python developer is 3 years." }, { JobTitle: "PHP Developer", CompanyName: "Aitrich", Place: "Thrissur", mode: "Remote", Discription: "The average experience requirement of a Python developer is 3 years." });
        view.forEach(function (job, index) {
            console.log("".concat(index + 1, " "), "".concat(job.JobTitle, "\n"), "CompanyName : ".concat(job.CompanyName), "Place : ".concat(job.Place, "\n"), "Mode : ".concat(job.mode, "\n"), "Discription : ".concat(job.Discription, "\n"));
        });
        rl.question("Apply Job With ID : ", function (app1) {
            var selectedIndex = parseInt(app1) - 1;
            if (selectedIndex >= 0 && selectedIndex < view.length) {
                ap.push(__assign({}, view[selectedIndex]));
                _this.menu2();
            }
            else {
                console.log('Invalid option');
                _this.list();
            }
        });
    };
    Menu.prototype.apply = function () {
        ap.forEach(function (ap1) {
            console.log(ap1.JobTitle, "\nCompany : ", ap1.CompanyName, "\nPlace : ", ap1.Place, "               Mode : ", ap1.mode, '\n', ap1.Discription);
        });
        rl.close();
    };
    return Menu;
}());
var menu1 = new Menu();
menu1.main();
