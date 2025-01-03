
        document.addEventListener('DOMContentLoaded', function () {
            var myForm = document.getElementById('myForm');
            var profileArray = JSON.parse(localStorage.getItem('profileArray')) || [];
        
            myForm.addEventListener('submit', function (event) {
                event.preventDefault();
                var formData = new FormData(myForm);
                var formObject = Object.fromEntries(formData);
                createAccount(formObject);
                myForm.reset();
            });
        
            function createAccount(formData) {
                formData.id = generateUniqueID();
                profileArray.push(formData);
                localStorage.setItem('profileArray', JSON.stringify(profileArray));
                alert("Registered Successfully");
                console.log("Stored profiles:", profileArray); // Debugging: Check the stored profiles
            }
        
            function generateUniqueID() {
                const timestamp = new Date().getTime();
                const randomComponent = Math.random().toString(36).substr(2, 9);
                return `${timestamp}-${randomComponent}`;
            }
        });
        