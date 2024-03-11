

//login code

function login() {
    var username = document.getElementById("username").value;
    var password = document.getElementById("userpassword").value;

    var existingData = localStorage.getItem("user_data");
    var userDataList = existingData ? JSON.parse(existingData) : [];

    var user = userDataList.find(user => user.uname === username && user.password === password);

    if (user) {
        alert("Login successful!");
        window.location.href = "deshbord.html";
    } else {
        alert("Invalid username or password");
    }
}

//signup code

function addData() {
    var uname = document.getElementById("uname").value;
    var password = document.getElementById("upassword").value;
    var confpassword = document.getElementById("confpassword").value;

    if (validateForm()) {

        var existingData = localStorage.getItem("user_data");
        var userDataList = existingData ? JSON.parse(existingData) : [];

        // Check if the username already exists
        var isDuplicate = userDataList.some(user => user.uname === uname);

        if (isDuplicate) {
            alert("Username already exists. Please choose a different username.");
        } else {


            var userData = {
                uname: uname,
                password: password,
                confpassword: confpassword
            };

            userDataList.push(userData);

            // Save the combined data back to local storage
            localStorage.setItem("user_data", JSON.stringify(userDataList));
            window.location.href = "index.html";

        }
    }

}

function clearFields() {
    document.getElementById("uname").value = "";
    document.getElementById("upassword").value = "";
    document.getElementById("confpassword").value = "";
    document.getElementById("err").innerHTML = "";
    document.getElementById("unameerr").innerHTML = "";
    document.getElementById("upasserr").innerHTML = "";
    document.getElementById("conferr").innerHTML = "";
}

function validateForm() {
    var isValid = true;

    var uname = document.getElementById("uname").value;
    var password = document.getElementById("upassword").value;
    var confpassword = document.getElementById("confpassword").value;

    var error = document.getElementById("err");
    var unameerror = document.getElementById("unameerr");
    var upassworderror = document.getElementById("upasserr");
    var uconfpasserror = document.getElementById("conferr");
// validate username
if (uname.trim() === "") {
    unameerror.innerHTML = "Username is required";
    isValid = false;
}

// Validate password
if (password.trim() === "") {
    upassworderror.innerHTML = "Password is required";
    isValid = false;
}

// Validate confirmPassword
if (confpassword.trim() === "") {
    uconfpasserror.innerHTML = "Confirm Password is required";
    isValid = false;
}

if (password !== confpassword) {
    error.innerHTML = "Passwords must match";
    isValid = false;
}

return isValid;
}