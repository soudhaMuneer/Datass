import * as readline from 'readline';

interface Signup {
    un: string;
    fn: string;
    ln: string;
    ph: string;
    gn: string;
    pw: string;
}

interface App {
    JobTitle: string;
    CompanyName: string;
    Place: string;
    mode: string;
    Discription: string;
}

interface Listed {
    JobTitle: string;
    CompanyName: string;
    Place: string;
    mode: string;
    Discription: string;
}

const ap: App[] = [];
const view: Listed[] = [];

const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});

const pass: Signup[] = [];

class Menu {
    main() {
        console.log("1.SignUp", "\n" + "2.Login", "\n" + "3.Exit");
        rl.question("Select ", (select) => {
            switch (select) {
                case '1':
                    this.signup();
                    break;
                case '2':
                    this.login();
                    break;
                case '3':
                    rl.close();
                    break;
                default:
                    console.log('Invalid option');
                    break;
            }
        });
    }

    signup() {
        console.log("-------------------------------------------------- Signup --------------------------------------------------");
        rl.question("UserName : ", (un: string) => {
            rl.question("FirstName : ", (fn: string) => {
                rl.question("LastName : ", (ln: string) => {
                    rl.question("Gender : ", (gn: string) => {
                        rl.question("Phone : ", (ph: string) => {
                            rl.question("Password : ", (pw: string) => {
                                if (un === "" || fn === "" || ln === "" || gn === "" || ph === '' || pw === '') {
                                    console.log("Invalid input");
                                    this.main();
                                } else {
                                    const pus: Signup = {
                                        un,
                                        fn,
                                        ln,
                                        ph,
                                        gn,
                                        pw
                                    };
                                    pass.push(pus);
                                    this.login();
                                }
                            });
                        });
                    });
                });
            });
        });
    }

    login() {
        console.log("-------------------------------------------------- Login --------------------------------------------------");
        rl.question("UserName : ", (ul) => {
            rl.question("Password : ", (pl) => {
                const userFound = pass.some(user => user.un === ul && user.pw === pl);

                if (userFound) {
                    this.menu2();
                } else {
                    console.log("Invalid credentials. Please try again.");
                    this.signup();
                }
            });
        });
    }

    menu2() {
        console.log('------------------------------------------------------------------------------------------------------------\n');
        console.log(`1.Jobs     2.Applied Jobs     3.Logout                                     Welcome to JobPlatform`);

        rl.question("Choose", (id) => {
            switch (id) {
                case '1':
                    this.list();
                    break;
                case '2':
                    this.apply();
                    break;
                case '3':
                    this.main();
                    break;
                default:
                    console.log('Invalid option');
                    break;
            }
        });
        console.log('\n------------------------------------------------------------------------------------------------------------');
    }

    list() {
        view.push(
            { JobTitle: "Python Developer", CompanyName: "Aitrich", Place: "Thrissur", mode: "Remote", Discription: "The average experience requirement of a Python developer is 3 years." },
            { JobTitle: ".NET Developer", CompanyName: "Aitrich", Place: "Thrissur", mode: "Remote", Discription: "The average experience requirement of a Python developer is 3 years." },
            { JobTitle: "Angular Developer", CompanyName: "Aitrich", Place: "Thrissur", mode: "Remote", Discription: "The average experience requirement of a Python developer is 3 years." },
            { JobTitle: "PHP Developer", CompanyName: "Aitrich", Place: "Thrissur", mode: "Remote", Discription: "The average experience requirement of a Python developer is 3 years." }
        );

        view.forEach((job, index) => {
            console.log(`${index + 1} `, `${job.JobTitle}\n`, `CompanyName : ${job.CompanyName}`, `Place : ${job.Place}\n`, `Mode : ${job.mode}\n`, `Discription : ${job.Discription}\n`);
        });

        rl.question("Apply Job With ID : ", (app1) => {
            const selectedIndex = parseInt(app1) - 1;

            if (selectedIndex >= 0 && selectedIndex < view.length) {
                ap.push({ ...view[selectedIndex] });
                this.menu2();
            } else {
                console.log('Invalid option');
                this.list();
            }
        });
    }

    apply() {
        ap.forEach((ap1) => {
            console.log(ap1.JobTitle, "\nCompany : ", ap1.CompanyName, "\nPlace : ", ap1.Place, "               Mode : ", ap1.mode, '\n', ap1.Discription);
        });

        rl.close();
    }
}

const menu1 = new Menu();
menu1.main();
