
import * as readline from 'readline';
import { Applicants } from './Applicants';
import { Interview } from './Interview';
import { scheduled } from './scheduled';

const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});


const menuOptions = [
    '1. Show Applicant List',
    '2. Schedule Interview',
    '3. Show Scheduled InterviewList',
    '0. Exit'
];

let exitProgram = false;
var obj: Interview;
let interviewList: Interview[] = [];

var localStorage: string = "";

class JobProvider {
    constructor() { }
    showMenu() {

        console.log("******************************************************* Welcome To Job Portal********************************************************");
        menuOptions.forEach(option => console.log(option));

        rl.question('Enter your choice: ', (input: string) => {
            this.selectOption(input);

            if (exitProgram) {
                rl.close();
            } else {
                this.showMenu();
            }
        });
    }

    selectOption(input: string) {
        switch (input) {
            case '1':
                this.applicantList();
                break;
            case '2':
                this.scheduleInterview();
                break;
                case '3':
                    this.interviewScheduledList();
                    break;
            case '0':
                exitProgram = true;
                break;
            default:
                console.log('Invalid option');
                break;
        }
    }

    applicantList() {
        var applicantsList: Applicants[] = [
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
        console.log("\n--------------------------------------------------Applicants List-----------------------------------------------\n")
        applicantsList.forEach(list => {

            console.log("Name:" + list.name + " JobTitle: " + list.jobTitle + " Qualification: " + list.qualification + " Experience: " + list.experience + "\n")
        }

        )
        console.log("\n------------------------------------------------------------------------------------------------------------\n")

    }

    scheduleInterview() {
        var result: any = this.auth();
        if (result) {

            console.log("-------------------------Interview Schedule------------------");
            rl.question('Enter job title: ', (jobTitle) => {
                rl.question('Enter interview date(yyyy-mm-dd): ', (interviewDate) => {
                    const dateOfInterview: Date = new Date(interviewDate);
                    rl.question('Enter interview time: ', (time) => {
                        rl.question('Enter interview mode: ', (modeOfInterview) => {
                            const interviewData: Interview = {
                                jobTitle,
                                dateOfInterview,
                                time,
                                modeOfInterview
                            };
                            interviewList.push(interviewData);
                            this.showMenu();

                        });
                    });
                });
            });
        }
        else {
            this.login();
        }
    }
    login(): any {
        console.log("please login")
        rl.question('Enter your username: ', (username) => {

            rl.question('Enter your password: ', (password) => {
                if (username == "admin" && password == "admin123") {
                    console.log('Login successful.');
                    localStorage = "admin";
                    this.scheduleInterview();
                    return true;

                } else {
                    console.log('Invalid username or password. Please try again.!!!!!!!!!!!\n');
                    console.log('\x1b[31m%s\x1b[0m', '\u26A0', 'Error: Something went wrong!');
                    this.login();
                }
            });
        });
    }

    auth(): any {

        if (localStorage) {
            return true;
        }
        else {
            return this.login();
        }
    }

    interviewScheduledList() {
        var interviewScheduledList: scheduled[] = [
                {
                    
                    jobTitle: "Java Developer",
                    date: "Thu Nov 23 2023 05:30:00 GMT +0530 (Indian Standard time) ",
                    time: "10:00 am",
                   location: "online"
                },
                {
                    jobTitle: "Java Developer",
                    date: "Tue Jul 25 2023 00:00:00 GMT +0530 (Indian Standard time) ",
                    time: "10:30 am",
                   location: "online"
                },
                {
                    jobTitle: "Java Developer",
                    date: "Sun Jul 30 2023 00:00:00 GMT +0530 (Indian Standard time) ",
                    time: "10:30 am",
                   location: "offline"
                }
               
            ];
            console.log("\n--------------------------------------------------interview Scheduled List-----------------------------------------------\n");
            interviewScheduledList.forEach(function (jest) {
                console.log( " JobTitle: " + jest.jobTitle +"date:" + jest.date +  " time: " + jest.time + " location: " + jest.location + "\n");
            });
            console.log("\n------------------------------------------------------------------------------------------------------------\n");
    
     };
}


var jobProviderRef = new JobProvider();
jobProviderRef.showMenu();




