"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var readline = require("readline");
var rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});
var menuoptions = [
    '1.Post job',
    '2.List job',
    '3.Remove job',
    '4.Search job',
    '5.Logout'
];
var joblist = [];
var jobposted = false;
var jobss = /** @class */ (function () {
    function jobss() {
    }
    // Login or Exit
    jobss.prototype.showmenu = function () {
        var _this = this;
        console.log('\n===============================================Menu===============================================\n');
        rl.question('1.Login\n2.Exit\nChoose what you wanna do :', function (input) {
            switch (input) {
                case '1':
                    _this.userlogin();
                    break;
                case '2':
                    console.log('exiting.....');
                    rl.close();
                    break;
                default:
                    console.log('\x1b[31m%s\x1b[0m', '\u26A0', 'Choose valid option');
                    _this.showmenu();
                    break;
            }
        });
    };
    // Login
    jobss.prototype.userlogin = function () {
        var _this = this;
        rl.question('enter your username : ', function (usrname) {
            rl.question('enter you password : ', function (usrpassword) {
                if (usrname == "shahid" && usrpassword == "1234") {
                    console.log("login successfull");
                    _this.ChooseOption();
                }
                else {
                    console.log('invalid username or password\n');
                    _this.userlogin();
                }
            });
        });
    };
    // user dashboard
    jobss.prototype.ChooseOption = function () {
        var _this = this;
        // post job, job list, remove job, search job and logout
        console.log("\n\n******************************************************* Welcome To Job Portal********************************************************");
        menuoptions.forEach(function (element) {
            console.log(element);
        });
        rl.question('enter your choice : ', function (input) {
            switch (input) {
                case '1':
                    _this.Postjob();
                    break;
                // post job
                case '2':
                    _this.Listjob();
                    break;
                // job list
                case '3':
                    _this.removejob();
                    break;
                // remove job
                case '4':
                    _this.searchjob();
                    break;
                // search job
                case '5':
                    console.log('****************************You have logged out************************************');
                    _this.showmenu();
                    break;
                // logout
                default:
                    console.log('\x1b[31m%s\x1b[0m', '\u26A0', 'enter valid input');
                    _this.ChooseOption();
            }
        });
    };
    // postjob
    jobss.prototype.Postjob = function () {
        var _this = this;
        rl.question('enter job title :', function (jobtitle) {
            rl.question('enter job location : ', function (location) {
                rl.question('enter job timing : ', function (jobtime) {
                    rl.question('enter job id : ', function (id) {
                        var jobDetail = {
                            jobtitle: jobtitle,
                            location: location,
                            jobtime: jobtime,
                            id: id
                        };
                        joblist.push(jobDetail);
                        jobposted = true;
                        _this.ChooseOption();
                    });
                });
            });
        });
    };
    // list job
    jobss.prototype.Listjob = function () {
        if (jobposted) {
            console.log('**************************************** Posted jobs****************************************');
            joblist.forEach(function (element) {
                console.log('\nJob : ' + element.jobtitle + '\nlocation : ' + element.location + '\ntiming : ' + element.jobtime + '\nId id : ' + element.id);
                console.log('---------------------------------');
            });
        }
        else {
            console.log('\x1b[31m%s\x1b[0m', '\u26A0', 'No jobs Posted');
        }
        this.ChooseOption();
    };
    // remove job
    jobss.prototype.removejob = function () {
        if (joblist.length > 0) {
            var removed = joblist.pop();
            console.log('--------------Job removed---------------\n' + (removed === null || removed === void 0 ? void 0 : removed.jobtitle));
        }
        else {
            console.log('\x1b[31m%s\x1b[0m', '\u26A0', 'no job posted');
        }
        if (joblist.length == 0) {
            jobposted = false;
        }
        this.ChooseOption();
    };
    // search job
    jobss.prototype.searchjob = function () {
        if (jobposted) {
            console.log('--------------------------Search job----------------------');
            rl.question('enter job name:', function (jname) {
                console.log('---------------------');
                joblist.forEach(function (element) {
                    if (element.jobtitle === jname) {
                        console.log('Job found : ' + element.id + ':' + element.jobtitle);
                    }
                    else {
                        console.log('not found');
                    }
                });
            });
        }
        else {
            console.log('\x1b[31m%s\x1b[0m', '\u26A0', 'no job posted');
        }
        this.ChooseOption();
    };
    return jobss;
}());
var star = new jobss();
star.showmenu();
