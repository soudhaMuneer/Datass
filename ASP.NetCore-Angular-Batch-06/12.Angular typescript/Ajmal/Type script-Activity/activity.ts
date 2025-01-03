import * as readline from 'readline';

    const rl = readline.createInterface({
      input: process.stdin,
      output: process.stdout,
    });
    class txt{
  main(){  

console.log("1.Register  2.Login  3.Exit");
rl.question("Choose any ", (id) => {
    const details : [ { User:string , Password:any } ] =[
        {User:"Hruthu",Password:1234}
    ];
    
switch(id){
    case '1':
        rl.question("User : ", (name) => {
                rl.question("Password : ", (passord) => {
                if(name=="" && passord=="" || name==null && passord==null){
                    console.log("Invalid name or password ");
                    rl.close();
                }
                else{
                    details.push({User:name,Password:passord});

                    console.log(details);
                    
                    
                    
                    rl.close();
                }
            })
        })
        

    case '2':
        
        rl.question("User : ", (name) => {
        rl.question("Password : ", (password) => {
        if(name==details[0].User && password==details[0].Password){
            console.log("Hello," +name );
            rl.close();
        }
        else{
            
            console.log("Invalid name or password ");
            rl.close();
        }
        
    });

    });

    case '3':
        rl.question('Is this example useful? [y/n] ', (answer) => {
            switch(answer.toLowerCase()) {
            case 'y':
                console.log('Successfully Signout');
                break;
            case 'n':
                console.log("Welcome Back");
                break;
            default:
                console.log('Invalid answer!');
            }
            rl.close();
        });
       
    
        
      default: 
}
});
 };
}
 var main1= new 
