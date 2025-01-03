"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var readline = require("readline");
var ap = [];
var view = [];
var rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});
var pass = [];
var menu = /** @class */ (function () {
    function menu() {
    }
    menu.prototype.main = function () {
        var _this = this;
        console.log("1.SignUp", "\n" + "2.Login", "\n" + "3.Exit");
        rl.question("select ", function (select) {
            switch (select) {
                case '1':
                    _this.signp();
                    break;
                case '2':
                    _this.login();
                    break;
                case '3': rl.close();
                default:
                    console.log('Invalid option');
                    break;
            }
        });
    };
    menu.prototype.signp = function () {
        var _this = this;
        console.log("-------------------------------------------------- Signup --------------------------------------------------");
        rl.question("UserName : ", function (User) {
            rl.question("FirstName : ", function (FirstName) {
                rl.question("LastName : ", function (LastName) {
                    rl.question("Gender : ", function (Gender) {
                        rl.question("Phone : ", function (Phone) {
                            rl.question("password : ", function (Password) {
                                if (User === "" && FirstName === "" && LastName === "" && Gender === "" && Phone === '' && Password === '') {
                                    console.log("invalid");
                                    _this.main();
                                }
                                else {
                                    var pus = {
                                        User: User,
                                        FirstName: FirstName,
                                        LastName: LastName,
                                        Phone: Phone,
                                        Gender: Gender,
                                        Password: Password
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
    menu.prototype.login = function () {
        var _this = this;
        console.log("-------------------------------------------------- Login --------------------------------------------------");
        rl.question("UserName : ", function (User) {
            rl.question("Password : ", function (Password) {
                var userlogin = pass.some(function (user) { return User === user[-1].User && Password === user[-1].Password; });
                if (userlogin) {
                    _this.menu2();
                }
                else {
                    _this.signp();
                }
            });
        });
    };
    menu.prototype.menu2 = function () {
        var _this = this;
        console.log('------------------------------------------------------------------------------------------------------------\n');
        console.log("1.Jobs     2.Applied Jobs     3.Logout                                     Welcome to JobPlatform");
        rl.question("choose", function (id) {
            switch (id) {
                case '1':
                    _this.list();
                    break;
                case '2':
                    _this.apply();
                    break;
                // case '3':
                //         // this.apply();
                //         break;
                case '3':
                    _this.login();
                    break;
                default:
                    console.log('Invalid option');
                    break;
            }
        });
        console.log('\n------------------------------------------------------------------------------------------------------------');
    };
    menu.prototype.list = function () {
        var _this = this;
        view.push({ JobTitle: "Python Developer", CompanyName: "Aitrich", Place: "Thrissur", mode: "Remote", Discription: "The average experience requirement of a Python developer is 3 years." }, { JobTitle: ".NET Developer", CompanyName: "Aitrich", Place: "Thrissur", mode: "Remote", Discription: "The average experience requirement of a Python developer is 3 years." }, { JobTitle: "Angular Developer", CompanyName: "Aitrich", Place: "Thrissur", mode: "Remote", Discription: "The average experience requirement of a Python developer is 3 years." }, { JobTitle: "PHP Developer", CompanyName: "Aitrich", Place: "Thrissur", mode: "Remote", Discription: "The average experience requirement of a Python developer is 3 years." });
        console.log("1 ", "".concat(view[0].JobTitle, "\n"), "CompanyName : ".concat(view[0].CompanyName), "Place : ".concat(view[0].Place, "\n"), "        Mode : ".concat(view[0].mode, "\n"), "Discription : ".concat(view[0].Discription, "\n"));
        console.log("2 ", "".concat(view[1].JobTitle, "\n"), "CompanyName : ".concat(view[1].CompanyName), "Place : ".concat(view[1].Place, "\n"), "         Mode : ".concat(view[1].mode, "\n"), "Discription : ".concat(view[1].Discription, "\n"));
        console.log("3 ", "".concat(view[2].JobTitle, "\n"), "CompanyName : ".concat(view[2].CompanyName), "Place : ".concat(view[2].Place, "\n"), "         Mode : ".concat(view[2].mode, "\n"), "Discription : ".concat(view[2].Discription, "\n"));
        console.log("4 ", "".concat(view[3].JobTitle, "\n"), "CompanyName : ".concat(view[3].CompanyName), "Place : ".concat(view[3].Place, "\n"), "         Mode : ".concat(view[3].mode, "\n"), "Discription : ".concat(view[3].Discription));
        rl.question("Apply Job With ID : ", function (app1) {
            // var ap1=ap
            switch (app1) {
                case '1':
                    ap.push({ JobTitle: view[0].JobTitle, CompanyName: view[0].CompanyName, Place: view[0].Place, mode: view[0].mode, Discription: view[0].Discription });
                    _this.menu2();
                    break;
                case '2':
                    ap.push({ JobTitle: view[1].JobTitle, CompanyName: view[1].CompanyName, Place: view[1].Place, mode: view[1].mode, Discription: view[1].Discription });
                    _this.menu2();
                    break;
                case '3':
                    ap.push({ JobTitle: view[2].JobTitle, CompanyName: view[2].CompanyName, Place: view[2].Place, mode: view[2].mode, Discription: view[2].Discription });
                    _this.menu2();
                    break;
                case '4':
                    ap.push({ JobTitle: view[3].JobTitle, CompanyName: view[3].CompanyName, Place: view[3].Place, mode: view[3].mode, Discription: view[3].Discription });
                    _this.menu2();
                    break;
                default:
                    console.log('Invalid option');
                    break;
            }
        });
    };
    //  app:{
    //     JobTitle:string;
    //     CompanyName:string;
    //     Place:string;
    //     mode:string;
    //     Discription:string;
    // }[]=[];
    menu.prototype.apply = function () {
        ap.forEach(function (ap1) {
            console.log(ap1.JobTitle, "\nCompany : ", ap1.CompanyName, "\nPlace : ", ap1.Place, "               Mode : ", ap1.mode, '\n', ap1.Discription);
        });
        rl.close();
    };
    return menu;
}());
var menu1 = new menu();
menu1.main();
