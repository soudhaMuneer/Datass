import * as readline from 'readline';
import { job } from "./job";

const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});
const menuoptions = [
    '1.Post job',
    '2.List job',
    '3.Remove job',
    '4.Search job',
    '5.Logout'
];

let joblist: job[] = [];
let jobposted = false;


class jobss {
    // Login or Exit
    showmenu() {
        console.log('\n===============================================Menu===============================================\n');
        rl.question('1.Login\n2.Exit\nChoose what you wanna do :', (input) => {
            switch (input) {
                case '1':
                    this.userlogin();
                    break;
                case '2':
                    console.log('exiting.....')
                    rl.close();
                    break;
                default:
                    console.log('\x1b[31m%s\x1b[0m', '\u26A0','Choose valid option');
                    this.showmenu();
                    break;
            }
        })

    }
    // Login
    userlogin() {
        rl.question('enter your username : ', (usrname) => {
            rl.question('enter you password : ', (usrpassword) => {
                if (usrname == "shahid" && usrpassword == "1234") {
                    console.log("login successfull");
                    this.ChooseOption();

                }
                else {
                    console.log('invalid username or password\n')
                    this.userlogin();
                }

            })
        });

    }
    // user dashboard
    ChooseOption() {
        // post job, job list, remove job, search job and logout
        console.log("\n\n******************************************************* Welcome To Job Portal********************************************************");
        menuoptions.forEach(element => {
            console.log(element);
        });
        rl.question('enter your choice : ', (input) => {
            switch (input) {
                case '1':
                    this.Postjob();
                    break;
                    // post job
                case '2':
                    this.Listjob();
                    break;
                    // job list
                case '3':
                    this.removejob();
                    break;
                    // remove job
                case '4':
                    this.searchjob();
                    break;
                    // search job
                case '5':
                    console.log('****************************You have logged out************************************');
                    this.showmenu();
                    break;
                    // logout
                    default:
                        console.log('\x1b[31m%s\x1b[0m', '\u26A0', 'enter valid input');
                        this.ChooseOption();
            }

        })
    }
    // postjob
    Postjob(){
        rl.question('enter job title :',(jobtitle)=>{
            rl.question('enter job location : ',(location)=>{
                rl.question('enter job timing : ',(jobtime)=>{
                    rl.question('enter job id : ',(id)=>{
                        const jobDetail : job ={
                            jobtitle,
                            location,
                            jobtime ,
                            id
                        };
                        joblist.push(jobDetail);
                        jobposted = true;
                        this.ChooseOption();
                    })
                })
            })
        })
    }
    // list job
    Listjob(){
        if(jobposted){
            console.log('**************************************** Posted jobs****************************************');
        joblist.forEach(element => {
            console.log('\nJob : ' + element.jobtitle + '\nlocation : ' + element.location + '\ntiming : ' + element.jobtime + '\nId id : ' + element.id);
            console.log('---------------------------------')
        })
        }
        else{
            console.log('\x1b[31m%s\x1b[0m', '\u26A0', 'No jobs Posted');
        }
        this.ChooseOption();
    }
    // remove job
    removejob(){
        
        if(joblist.length > 0){
            var removed = joblist.pop();
        console.log('--------------Job removed---------------\n' +removed?.jobtitle);
        }
        else{
            console.log('\x1b[31m%s\x1b[0m', '\u26A0', 'no job posted')
        }
        if(joblist.length == 0){
            jobposted = false;
        }
        this.ChooseOption();      

    }
    // search job
    searchjob(){
        if(jobposted){
            console.log('--------------------------Search job----------------------');
        rl.question('enter job name:',(jname)=>{
            console.log('---------------------')
            joblist.forEach(element => {
                if(element.jobtitle === jname){
                    console.log('Job found : ' + element.id+ ':' + element.jobtitle);

                }
                else{
                    console.log('not found');
                }
            });
        })
        }
        else{
            console.log('\x1b[31m%s\x1b[0m', '\u26A0', 'no job posted');
        }
        this.ChooseOption();
    }

}

var star = new jobss();
star.showmenu();
