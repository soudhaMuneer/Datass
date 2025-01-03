

document.addEventListener('DOMContentLoaded', function () {
    var loginForm = document.getElementById('myloginForm');
    var profileArray = JSON.parse(localStorage.getItem('profileArray')) || [];

    // Debugging: Check the retrieved profiles
    console.log("Retrieved profiles from localStorage:", profileArray);

    loginForm.addEventListener('submit', function (event) {
        event.preventDefault();
        login();
    });

    function login() {
        var username = document.getElementById('username').value;
        var password = document.getElementById('password').value;

        // Debugging: Log input values
        console.log("Input username:", username);
        console.log("Input password:", password);

        let userFound = null; // Initialize userFound as null

        profileArray.forEach(function (profile) {
            console.log("Checking profile:", profile); // Debugging: Check each profile
            if (profile.username === username && profile.password === password) {
                userFound = profile; // Set userFound if a match is found
            }
        });

        // Debugging: Check if user is found
        console.log("User found:", userFound);

        if (userFound) {
            alert('Login successful');
            window.location = './home.html';
        } else {
            alert('Login failed');
        }
    }
});
