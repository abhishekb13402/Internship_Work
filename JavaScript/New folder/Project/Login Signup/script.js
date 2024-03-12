
//login code

function login() {
    var username = document.getElementById("username").value;
    var password = document.getElementById("userpassword").value;
    var loginerr = document.getElementById("loginerr");
    var addbtn = document.getElementById("addbtn");

    console.log(addbtn); 
    if (validateLoginForm()) {
        var existingData = localStorage.getItem("user_data");
        var userDataList = existingData ? JSON.parse(existingData) : [];

        var user = userDataList.find(user => user.uname === username && user.password === password);
        if (user) {
            //alert("Login successful!");
            var isuserAdmin = user.role === 'Admin';
            alert(isuserAdmin);
            if (isuserAdmin) {
                alert("admin..")

                // addbtn.style.display = "block";

                //console.log("HERE", document.getElementById("addbtn"))
                window.location.href = "Dashboard.html";
            } else {
                alert("normal user..")
                // addbtn.style.display = "none";

                window.location.href = "Dashboard.html";
            }

        } else {
            //alert("Invalid username or password");
            loginerr.innerHTML = "Invalid username or password";
            clearFields();
        }
    }


}

function validateLoginForm() {
    var isValid = true;

    var loginuname = document.getElementById("username").value;
    var loginpassword = document.getElementById("userpassword").value;

    var usernameerr = document.getElementById("usernameerr");
    var userpassworderr = document.getElementById("userpassworderr");

    // validate username
    if (loginuname.trim() === "") {
        usernameerr.innerHTML = "Username is required";
        isValid = false;
    }

    // Validate password
    if (loginpassword.trim() === "") {
        userpassworderr.innerHTML = "Password is required";
        isValid = false;
    }
    return isValid;


}

//signup code

function addData() {
    var uname = document.getElementById("uname").value;
    var password = document.getElementById("upassword").value;
    var confpassword = document.getElementById("confpassword").value;
    var gender = document.getElementById("ugender").value;
    var role = document.getElementById("role").value;

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
                confpassword: confpassword,
                gender: gender,
                role: role
            };

            userDataList.push(userData);

            // Save the combined data back to local storage
            localStorage.setItem("user_data", JSON.stringify(userDataList));
            window.location.href = "index.html";

        }
    }

}

function clearFields() {
    //signup input fields
    document.getElementById("uname").value = "";
    document.getElementById("upassword").value = "";
    document.getElementById("confpassword").value = "";
    document.getElementById("ugender").value = "";
    document.getElementById("role").value = "";
    //signup err
    document.getElementById("err").innerHTML = "";
    document.getElementById("unameerr").innerHTML = "";
    document.getElementById("upasserr").innerHTML = "";
    document.getElementById("conferr").innerHTML = "";
    document.getElementById("gendererr").innerHTML = "";
    document.getElementById("roleerr").innerHTML = "";
    //login input fields
    document.getElementById("username").value = "";
    document.getElementById("userpassword").value = "";
    //login err
    document.getElementById("usernameerr").innerHTML = "";
    document.getElementById("userpassworderr").innerHTML = "";

}

function validateForm() {
    var isValid = true;

    var uname = document.getElementById("uname").value;
    var password = document.getElementById("upassword").value;
    var confpassword = document.getElementById("confpassword").value;
    var gender = document.getElementById("ugender").value;
    var role = document.getElementById("role").value;


    var error = document.getElementById("err");
    var unameerror = document.getElementById("unameerr");
    var upassworderror = document.getElementById("upasserr");
    var uconfpasserror = document.getElementById("conferr");
    var gendererr = document.getElementById("gendererr");
    var roleerr = document.getElementById("roleerr");
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

    //validate password confpassword
    if (password !== confpassword) {
        error.innerHTML = "Passwords must match";
        isValid = false;
    }

    //validate gender
    if (gender === "") {
        gendererr.innerHTML = "Gender field is required";
        isValid = false;
    }

    //validate role
    if (role === "") {
        roleerr.innerHTML = "Role is required";
        isValid = false;
    }

    return isValid;
}

