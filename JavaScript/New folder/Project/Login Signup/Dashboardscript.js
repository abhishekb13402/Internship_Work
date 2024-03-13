
//Dashboard code

function displayTable() {
    var table = document.getElementById("productTable");
    if (table.style.display == "none") {
        table.style.display = "block";
    } else {
        table.style.display = "none";

    }
}

//add Product Data to table and localstorage

function addProductData() {
    var prodId = document.getElementById("productId").value;
    var prodName = document.getElementById("productNane").value;
    var prodQuantity = document.getElementById("productQuantity").value;

    var table = document.getElementById("productDataTable");
    var newRow = table.insertRow(table.rows.length);
    var cell1 = newRow.insertCell(0);
    var cell2 = newRow.insertCell(1);
    var cell3 = newRow.insertCell(2);
    var cell4 = newRow.insertCell(3);

    cell1.innerHTML = prodId;
    cell2.innerHTML = prodName;
    cell3.innerHTML = prodQuantity;
    cell4.innerHTML = '<button onclick="deleteRow(this)">Delete</button>';

    saveDataToLocalStorage();
    clearproductForm();


}

function clearproductForm() {
    document.getElementById("productId").value = "";
    document.getElementById("productNane").value = "";
    document.getElementById("productQuantity").value = "";
}

//delete and load data

function deleteRow(button) {
    var row = button.parentNode.parentNode;
    var table = document.getElementById("productDataTable");

    var rowIndex = row.rowIndex;

    table.deleteRow(rowIndex);

    removeFromLocalStorage(rowIndex - 1);


}

function removeFromLocalStorage(index) {
    var storedData = JSON.parse(localStorage.getItem("formData"));

    if (storedData && storedData.length > index) {
        storedData.splice(index, 1);
        localStorage.setItem("formData", JSON.stringify(storedData));
    }
}


function saveDataToLocalStorage() {
    var saveprodId = document.getElementById("productId").value;
    var saveprodName = document.getElementById("productNane").value;
    var saveprodQuantity = document.getElementById("productQuantity").value;


    const formData = {
        sprodId: saveprodId,
        sprodName: saveprodName,
        sprodQuantity: saveprodQuantity
    };

    const storedFormData = JSON.parse(localStorage.getItem('formData')) || [];

    storedFormData.push(formData);

    localStorage.setItem('formData', JSON.stringify(storedFormData));
}

// function loadDataFromLocalStorage(){

// }

function loadDataFromLocalStorage() {
    var table = document.getElementById("productDataTable");
    var storedData = localStorage.getItem("formData");
    var error = document.getElementById("Error");

    if (storedData) {
        var data = JSON.parse(storedData);

        // Check if data has already been loaded
        if (table.rows.length > 0) {
            // Check if the number of rows in the table matches the data in local storage
            if (table.rows.length !== data.length) {
                // Mismatch, reload the data
                reloadTableWithData(data);
            } else {
                error.innerHTML = "Data is already loaded.";

            }
        } else {
            // Table is empty, load the data
            reloadTableWithData(data);
        }
    } else {
        error.innerHTML = "No data found in local storage.";

    }
}

function reloadTableWithData(data) {
    var table = document.getElementById("productDataTable");

    // Load new data
    for (var i = 0; i < data.length; i++) {
        var newRow = table.insertRow(table.rows.length);
        var cell1 = newRow.insertCell(0);
        var cell2 = newRow.insertCell(1);
        var cell3 = newRow.insertCell(2);
        var cell4 = newRow.insertCell(3);

        cell1.innerHTML = data[i].sprodId;
        cell2.innerHTML = data[i].sprodName;
        cell3.innerHTML = data[i].sprodQuantity;
        cell4.innerHTML = '<button onclick="deleteRow(this)">Delete</button>';
    }
}

loadDataFromLocalStorage();

let addbtn = document.getElementById("addbtn")
let hideBtn = false;

let data = localStorage.getItem("user_data");
let currnetUser = localStorage.getItem("current-user");

if(data) {
    let dataArray = JSON.parse(data)
    
    dataArray.map(user => {
        console.log(user, currnetUser)
        if(user.uname === currnetUser && user.role === "Admin"){
            hideBtn = true;
        }
    })
}
if(hideBtn){
    addbtn.style.display = "block"
}else{
    addbtn.style.display = "none"
}
console.log(hideBtn)