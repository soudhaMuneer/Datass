
import * as readline from 'readline';
import { Applicants } from './Applicants';
import { Interview } from './Interview';

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
let showsheduled = false;
var localStorage = false;

class JobProvider {
    constructor() { }
    showMenu() {

        console.log("******************************************************* Welcome To Job Portal********************************************************");
        menuOptions.forEach(option => console.log(option));

        rl.question('Enter your choice: ', (input: string) => {
            this.selectOption(input);
            // doubt

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
                this.ShowSheduledInterview();
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
                // why 2 time
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
                            showsheduled = true;
                            this.showMenu();
                            // doubt

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
            // why 2 times

            rl.question('Enter your password: ', (password) => {
                if (username == "admin" && password == "admin123") {
                    console.log('Login successful.');
                    localStorage = true;
                    this.scheduleInterview();
                    
                    // why return true

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
    }

    ShowSheduledInterview(){
        if(showsheduled){
            console.log("----------------------------------------Interview sheduled List------------------------------------------");
        interviewList.forEach(value =>{
            console.log("\njob title : "+value.jobTitle+"\nDate : "+value.dateOfInterview+"\ntime : "+value.time+"\nLocation : "+value.modeOfInterview +"\n")
        })
        }
        else{
            console.log("++++++++++++++++++++++++++++++++++++No interview sheduled+++++++++++++++++++++++++++++++++++++++++++\n\n\n")
        }
    }
    

}

var jobProviderRef = new JobProvider();
jobProviderRef.showMenu();



