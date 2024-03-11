
//signup code

function addData(){
    if(validateForm()){

    }
}

function validateForm(){
    var isValid = true;

    var uname = document.getElementById("uname").value;
    var password = document.getElementById("upassword").value;
    var confpassword = document.getElementById("confpassword").value;

    var error = document.getElementById("err");
    var unameerror = document.getElementById("unameerr");
    var upassworderror = document.getElementById("upasserr");
    var uconfpasserror = document.getElementById("conferr");

    // validate uname
    if (uname.trim() === "") {
        unameerror.innerHTML = "User name is required";
        isValid = false;
    } else {
        unameerror.innerHTML = "";
    }

    // Validate upassword
    if (password.trim() === "") {
        upassworderror.innerHTML = "Password is required";
        isValid = false;
    } else {
        upassworderror.innerHTML = "";
    }

       // Validate conf password
       if (confpassword.trim() === "") {
        uconfpasserror.innerHTML = "Password is required";
        isValid = false;
    } else {
        uconfpasserror.innerHTML = "";
    }

    if(password != confpassword){
        error.innerHTML="Password must be match";
        isValid=false;
    }else{
        error.innerHTML="";
    }
}