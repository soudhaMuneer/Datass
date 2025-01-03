import * as readline from 'readline';
import { listed } from './signup';
import { app } from './apply';
import { signup } from './user';
const ap:app[]=[];
const view:listed[]=[];

const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});
interface signup{
    User: string;
    Firstname:string;
    Lastname:string;
    Phone:number;
    Gender:string;
    Password:any
    
}

var pass:signup[]=[];


class menu{
 main () {
    console.log("1.SignUp", "\n"+ "2.Login","\n" + "3.Exit");
rl.question("select ",(select)=>{
    switch(select){
        case '1':
        this.signp();
            break;
        case '2':this.login();
break;
        case '3':rl.close();
        default:
                console.log('Invalid option');
                break;
    }

});
}
 signp() {
    console.log("-------------------------------------------------- Signup --------------------------------------------------")

rl.question("UserName : ",(User:string)=>{
    rl.question("FirstName : ",(FirstName)=>{
        rl.question("LastName : ",(LastName)=>{
            rl.question("Gender : ",(Gender:string)=>{
                rl.question("Phone : ",(Phone:any)=>{
                    rl.question("password : ",(Password:any)=>{
                        
                    if (User==="" && FirstName===""&&LastName===""&&Gender===""&&Phone===''&&Password===''){
                        console.log("invalid");
                        this.main();
                    }
                    else{
                        const pus:signup={
                            User,
                            Firstname,
                            Lastname,
                            Phone,
                            Gender,
                            Password
                        };
                        pass.push(pus);
                        this.login();
                    }

                })
                })
            })
        }) 
    })
});

}
  
  login(){
    console.log("-------------------------------------------------- Login --------------------------------------------------")
    rl.question("UserName : ",(User)=>{
        rl.question("Password : ",(Password)=>{
           const userlogin = pass.some(user=>User===user[-1].User && Password===user[-1].Password)
if(userlogin){
this.menu2();

            }
            else{
                this.signp();
            }});
            
        })
    
              
  }
  menu2(){
    console.log('------------------------------------------------------------------------------------------------------------\n');
    console.log(`1.Jobs     2.Applied Jobs     3.Logout                                     Welcome to JobPlatform`);
    
    rl.question("choose",(id)=>{
switch(id){
    case '1':
         this.list();
        break;
    case '2':
        this.apply();
        break;
    // case '3':
    //         // this.apply();
    //         break;
    case '3':
        this.login();
        break;  
    default:
            console.log('Invalid option');
            break; 
}

    });
    console.log('\n------------------------------------------------------------------------------------------------------------');


  }
  list(){

    view.push(
    {JobTitle:"Python Developer",CompanyName:"Aitrich",Place:"Thrissur",mode:"Remote",Discription:"The average experience requirement of a Python developer is 3 years."},
    {JobTitle:".NET Developer",CompanyName:"Aitrich",Place:"Thrissur",mode:"Remote",Discription:"The average experience requirement of a Python developer is 3 years."},
    {JobTitle:"Angular Developer",CompanyName:"Aitrich",Place:"Thrissur",mode:"Remote",Discription:"The average experience requirement of a Python developer is 3 years."},
    {JobTitle:"PHP Developer",CompanyName:"Aitrich",Place:"Thrissur",mode:"Remote",Discription:"The average experience requirement of a Python developer is 3 years."}
    )
    console.log("1 ",`${view[0].JobTitle}\n`,`CompanyName : ${view[0].CompanyName}`,`Place : ${view[0].Place}\n`,`        Mode : ${view[0].mode}\n`,`Discription : ${view[0].Discription}\n`);
    console.log("2 ",`${view[1].JobTitle}\n`,`CompanyName : ${view[1].CompanyName}`,`Place : ${view[1].Place}\n`,`         Mode : ${view[1].mode}\n`,`Discription : ${view[1].Discription}\n`);
    console.log("3 ",`${view[2].JobTitle}\n`,`CompanyName : ${view[2].CompanyName}`,`Place : ${view[2].Place}\n`,`         Mode : ${view[2].mode}\n`,`Discription : ${view[2].Discription}\n`);
    console.log("4 ",`${view[3].JobTitle}\n`,`CompanyName : ${view[3].CompanyName}`,`Place : ${view[3].Place}\n`,`         Mode : ${view[3].mode}\n`,`Discription : ${view[3].Discription}`);
    rl.question("Apply Job With ID : ",(app1)=>{
        // var ap1=ap
        switch (app1){
            case '1':
                ap.push({JobTitle:view[0].JobTitle,CompanyName:view[0].CompanyName,Place:view[0].Place,mode:view[0].mode,Discription:view[0].Discription});
                this.menu2();
                break;
        case '2':
            ap.push({JobTitle:view[1].JobTitle,CompanyName:view[1].CompanyName,Place:view[1].Place,mode:view[1].mode,Discription:view[1].Discription});
            this.menu2();
break;
        case '3':
            ap.push({JobTitle:view[2].JobTitle,CompanyName:view[2].CompanyName,Place:view[2].Place,mode:view[2].mode,Discription:view[2].Discription});
            this.menu2();
            break;
        case '4':
        ap.push({JobTitle:view[3].JobTitle,CompanyName:view[3].CompanyName,Place:view[3].Place,mode:view[3].mode,Discription:view[3].Discription});
        this.menu2();
        break;
        default:
                console.log('Invalid option');
                break;
        }
            })
    

}
//  app:{
//     JobTitle:string;
//     CompanyName:string;
//     Place:string;
//     mode:string;
//     Discription:string;
// }[]=[];

  apply(){
    ap.forEach(ap1=>{
        console.log(ap1.JobTitle,"\nCompany : ",ap1.CompanyName,"\nPlace : ",ap1.Place, "               Mode : ",ap1.mode,'\n', ap1.Discription,);
    })
    
    rl.close();
   

  }

}
var menu1= new menu();
menu1.main()