class Registration {
    constructor(public name: string, public status: string) {}
  }
  
  class Program {
    private jobProviders: string[] = ["Aitrich", "Google", "SalesNrich"];
    private registrations: Registration[] = [
      new Registration("Rinshad", "pending"),
      new Registration("Jisni Parveen","on-hold"),
      new Registration("Ruaa Aroush", "candidate"),
    ];
  
    displayMenu(): void {
      console.log(`
  Options:
  1. Job Providers List
  2. New Registrations
  3. New Registrations - Pending
  4. New Registrations - On-Hold
  5. New Registrations - Candidate
  6. Exit
      `);
     
    }
  
    showJobProviders(): void {
      console.log("\nJob Providers List:");
    
      this.jobProviders.forEach((provider) => {
        console.log("- " + provider);
        
      });
     
     
      
      
    }
  
    showNewRegistrations(): void {
      console.log("\nNew Registrations:");
      this.registrations.forEach((registration) => {
        console.log("- " + registration.name);
      });
      
    }
  
    showNewRegistrationsByStatus(status: string): void {
      console.log(`\nNew Registrations - ${status.charAt(0).toUpperCase() + status.slice(1)}:`);
      this.registrations.forEach((registration) => {
        if (registration.status === status) {
          console.log("- " + registration.name);
        }
      });
      
    }
  
    run(): void {
      const readline = require("readline").createInterface({
        input: process.stdin,
        output: process.stdout,
      });
  
      const askUser = () => {
        this.displayMenu();
        
  
        readline.question("Enter your choice (1-6): ", (choice:string) => {
          if (choice === "1") {
            this.showJobProviders();
            askUser();
          } else if (choice === "2") {
            this.showNewRegistrations();
            askUser();
          } else if (choice === "3") {
            this.showNewRegistrationsByStatus("pending");
            askUser();
          } else if (choice === "4") {
            this.showNewRegistrationsByStatus("on-hold");
            askUser();
          } else if (choice === "5") {
            this.showNewRegistrationsByStatus("candidate");
            askUser();
          }
          else if (choice === "6") {
            // Exit the program
            console.log("Exiting the program. Goodbye see you next time!");
            readline.close();
          }
        });
      };
  
      readline.question("Enter your username: ", (username) => {
        readline.question("Enter your password: ", (password) => {
          // Perform authentication logic here (dummy check for demo purposes)
          if (username === "admin" && password === "admin123") {
            console.log("Login successful!");
            askUser();
          } else {
            console.log("Login failed. Please check your username and password.");
            readline.close();
          }
        });
      });
    }
  }
  
  const program = new Program();
  program.run();
  