"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var readline = require("readline");
var rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});
var menuOptions = [
    '1. Show Applicant List',
    '2. Schedule Interview',
    '3. Show Scheduled InterviewList',
    '0. Exit'
];
var exitProgram = false;
var obj;
var interviewList = [];
var showsheduled = false;
var localStorage = false;
var JobProvider = /** @class */ (function () {
    function JobProvider() {
    }
    JobProvider.prototype.showMenu = function () {
        var _this = this;
        console.log("******************************************************* Welcome To Job Portal********************************************************");
        menuOptions.forEach(function (option) { return console.log(option); });
        rl.question('Enter your choice: ', function (input) {
            _this.selectOption(input);
            // doubt
            if (exitProgram) {
                rl.close();
            }
            else {
                _this.showMenu();
            }
        });
    };
    JobProvider.prototype.selectOption = function (input) {
        switch (input) {
            case '1':
                this.applicantList();
                break;
            case '2':
                this.scheduleInterview();
                break;
            case '3':
                this.ShowSheduledInterview();
                break;
            case '0':
                exitProgram = true;
                break;
            default:
                console.log('Invalid option');
                break;
        }
    };
    JobProvider.prototype.applicantList = function () {
        var applicantsList = [
            {
                name: "Akash .A. ",
                jobTitle: "Java Developer",
                qualification: "Bca",
                experience: "2 Year"
            },
            {
                name: "Pakash P Babu",
                jobTitle: "Asp .Net Developer",
                qualification: "Mca",
                experience: "4 Year"
            },
            {
                name: "Baviya C Menon",
                jobTitle: "Asp .Net Developer",
                qualification: "Mca",
                experience: "1 Year",
            },
            {
                name: "Hrishika P Harish",
                jobTitle: "Front End Developer Angular",
                qualification: "Btech",
                experience: "3 Year"
            }
        ];
        console.log("\n--------------------------------------------------Applicants List-----------------------------------------------\n");
        applicantsList.forEach(function (list) {
            console.log("Name:" + list.name + " JobTitle: " + list.jobTitle + " Qualification: " + list.qualification + " Experience: " + list.experience + "\n");
        });
        console.log("\n------------------------------------------------------------------------------------------------------------\n");
    };
    JobProvider.prototype.scheduleInterview = function () {
        var result = this.auth();
        if (result) {
            console.log("-------------------------Interview Schedule------------------");
            rl.question('Enter job title: ', function (jobTitle) {
                // why 2 time
                rl.question('Enter interview date(yyyy-mm-dd): ', function (interviewDate) {
                    var dateOfInterview = new Date(interviewDate);
                    rl.question('Enter interview time: ', function (time) {
                        rl.question('Enter interview mode: ', function (modeOfInterview) {
                            var interviewData = {
                                jobTitle: jobTitle,
                                dateOfInterview: dateOfInterview,
                                time: time,
                                modeOfInterview: modeOfInterview
                            };
                            interviewList.push(interviewData);
                            showsheduled = true;
                            return true;
                            // doubt
                        });
                    });
                });
            });
        }
        else {
            this.login();
        }
    };
    JobProvider.prototype.login = function () {
        var _this = this;
        console.log("please login");
        rl.question('Enter your username: ', function (username) {
            // why 2 times
            rl.question('Enter your password: ', function (password) {
                if (username == "admin" && password == "admin123") {
                    console.log('Login successful.');
                    localStorage = true;
                    _this.scheduleInterview();
                    // why return true
                }
                else {
                    console.log('Invalid username or password. Please try again.!!!!!!!!!!!\n');
                    console.log('\x1b[31m%s\x1b[0m', '\u26A0', 'Error: Something went wrong!');
                    _this.login();
                }
            });
        });
    };
    JobProvider.prototype.auth = function () {
        if (localStorage) {
            return true;
        }
    };
    JobProvider.prototype.ShowSheduledInterview = function () {
        if (showsheduled) {
            console.log("----------------------------------------Interview sheduled List------------------------------------------");
            interviewList.forEach(function (value) {
                console.log("\njob title : " + value.jobTitle + "\nDate : " + value.dateOfInterview + "\ntime : " + value.time + "\nLocation : " + value.modeOfInterview + "\n");
            });
        }
        else {
            console.log("++++++++++++++++++++++++++++++++++++No interview sheduled+++++++++++++++++++++++++++++++++++++++++++\n\n\n");
        }
    };
    return JobProvider;
}());
var jobProviderRef = new JobProvider();
jobProviderRef.showMenu();
