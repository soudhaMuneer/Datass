function showPopup(event) {
 event.preventDefault();
  var form = document.getElementById("myForm");

  var Fullname = form.elements["Fullname"].value;
  var Username = form.elements["Username"].value;
  var Email = form.elements["Email"].value;
  var Phone = form.elements["Phone"].value;

  var popup = document.getElementById("popup");

  var popupFullname = document.getElementById("popup-Fullname");
  var popupUsername = document.getElementById("popup-Username");
  var popupEmail = document.getElementById("popup-Email");
  var popupPhone = document.getElementById("popup-Phone");

  popupFullname.textContent = Fullname;
  popupUsername.textContent = Username;
  popupEmail.textContent = Email;
  popupPhone.textContent = Phone;

  popup.style.display = "block";
}

function hidePopup() {

  var popup = document.getElementById("popup");

  
  popup.style.display = "none";
}



