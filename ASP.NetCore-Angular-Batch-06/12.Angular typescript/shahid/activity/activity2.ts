import { log } from 'console';
import * as readline from 'readline';

const rl = readline.createInterface({
  input: process.stdin,
  output: process.stdout
});
var arr : {name: string , password:string}[] =[{name:"shahid",password:"123"}];
rl.question('choose a number \n 1.register \n 2.login \n 3.exit \n',(chosen)=>{
    switch(chosen){
        case '1' :
            rl.question('registering user \n enter username',(usrname)=>{
                rl.question('enter password',(usrpassword)=>{
                    arr.push({name:usrname,password:usrpassword});
                    console.log(arr);
                    rl.close();
                });
            });
            break;
        case '2' :
            rl.question('enter username:',(name)=>{
                rl.question('enter password:',(password)=>{
                    if(arr[0].name==name && arr[0].password==password){
                        console.log("login succesfull");
                        console.log(`hello ${name}`)
                        rl.close();
                    }
                    else{
                        console.log("Incorrect username or password");
                        rl.close();
                    }
            
                });
            
            });            
            break;
        case '3':
            console.log('exiting...')
            rl.close();
            break;
        default:
            console.log('enter valid in put \n Exiting..');
            rl.close();
    }
});