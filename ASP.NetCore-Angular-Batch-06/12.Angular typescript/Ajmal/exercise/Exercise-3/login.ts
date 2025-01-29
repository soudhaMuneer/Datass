// login.ts

// Function to handle form submission
function handleLogin(event: Event) {
    event.preventDefault(); // Prevent the default form submission

    const username = (document.getElementById('username') as HTMLInputElement).value;
