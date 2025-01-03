"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var readline = require("readline");
var rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});
var User = /** @class */ (function () {
    function User(username, password) {
        this.username = username;
        this.password = password;
    }
    return User;
}());
var appliedJobs = [
    {
        title: 'Junior process Associate',
        companyName: 'Tcs',
        description: 'Product designer responsibilities include defining product specification',
        location: 'Indonesia',
        employmentType: 'Full Time',
        experienceLevel: 'Mid Level'
    },
    {
        title: 'Fresher',
        companyName: 'Penguin',
        description: 'Product designer',
        location: 'UK',
        employmentType: 'Full Time',
        experienceLevel: 'Low Level'
    },
    {
        title: 'Senior process Associate',
        companyName: 'Yoga Professor',
        description: 'Front-End designer',
        location: 'Canada',
        employmentType: 'Full Time',
        experienceLevel: 'Hight Level'
    }
];
var availableJobs = [
    {
        title: 'Junior Process Associate',
        companyName: 'Tcs',
        description: 'Product designer responsibilities include defining product specification',
        location: 'Indonesia',
        employmentType: 'Full Time',
        experienceLevel: 'Mid Level',
        salaryRange: '$3000 - $5000'
    },
    {
        title: 'Senior Process Associate',
        companyName: 'Tcs',
        description: 'Front-End designer',
        location: 'Indonesia',
        employmentType: 'Full Time',
        experienceLevel: 'High Level',
        salaryRange: '$5000 - $8000'
    }
];
var users = [new User('hruthu', '0000')];
function login() {
    console.log("*********Login************");
    rl.question('Username: ', function (username) {
        rl.question('Password: ', function (password) {
            var user = users.find(function (u) { return u.username === username && u.password === password; });
            if (user) {
                console.log('Login successful.');
                showMainMenu();
            }
            else {
                console.log('Login failed. Please try again.');
                login();
            }
        });
    });
}
function showMainMenu() {
    console.log('Main Menu:');
    console.log('1. All Jobs');
    console.log('2. My Applications');
    console.log('3. Logout');
    console.log('4. Exit');
    rl.question('Choose an option: ', function (option) {
        switch (option) {
            case '1':
                displayAllJobs();
                break;
            case '2':
                displayMyApplications();
                break;
            case '3':
                logout();
                break;
            case '4':
                rl.close();
                // document.write("Exit");
                break;
            default:
                console.log('Invalid option. Please try again.');
                showMainMenu();
        }
    });
}
function displayAllJobs() {
    console.log('Available Jobs:');
    availableJobs.forEach(function (j) {
        console.log("************************All jobs**********************");
        console.log("Title:" + j.title);
        console.log("CompanyName:" + j.companyName);
        console.log("Description:" + j.description);
        console.log("Location:" + j.location);
        console.log("EmploymentType:" + j.employmentType);
        console.log("ExperienceLevel:" + j.experienceLevel);
        console.log("SalarayRange:" + j.salaryRange);
        console.log("__________________________________________________________");
    });
    showMainMenu();
}
function displayMyApplications() {
    console.log('My Applications:');
    appliedJobs.forEach(function (f) {
        console.log("************************Applied job**********************");
        console.log("Title:" + f.title);
        console.log("CompanyName:" + f.companyName);
        console.log("Description:" + f.description);
        console.log("Location:" + f.location);
        console.log("EmploymentType:" + f.employmentType);
        console.log("ExperienceLevel:" + f.experienceLevel);
        console.log("_____________________________________________________________");
    });
    showMainMenu();
}
function logout() {
    console.log('Logged out successfully.');
    login();
}
login();
