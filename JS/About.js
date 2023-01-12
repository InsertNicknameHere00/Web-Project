//-----------------------------
//Changing maps in articleleft1
//-----------------------------
function changeMap(option) {
    if (option == 1) document.getElementById("map").src = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d1230483.1777743064!2d23.441820616037244!3d42.496802373032885!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x40aa8690c6a59ba7%3A0xa0624f4ae1d249e9!2z0J_Qu9Cw0YHQuNC60L4g0JrQvtC80L_RjtGC0YrRgNGBINCV0J7QntCU!5e0!3m2!1sbg!2sbg!4v1673557086281!5m2!1sbg!2sbg";
    else if (option == 2) document.getElementById("map").src = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d39804.02035163395!2d24.69089628244783!3d42.140631764688095!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14acd029a3f41799%3A0xff0582e1864fc2ac!2zUEMgU2VydmljZSDQn9C40KHQuCDQodGK0YDQstC40Lcg0JXQntCe0JQ!5e0!3m2!1sbg!2sbg!4v1673557647136!5m2!1sbg!2sbg";
    else document.getElementById("map").src = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d53753.333467972305!2d27.81846877422453!3d43.21280419978662!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x40a4549a90539bd1%3A0xcd03a5fa959f3082!2zUGxhc2ljbyBJVCBTdXBlcnN0b3JlINCS0LDRgNC90LA!5e0!3m2!1sbg!2sbg!4v1673557840963!5m2!1sbg!2sbg";
}
//------------------
//Checking functions
//------------------
function checkName(name) {
    if (name.length < 3) return false;
    for (var i = 0; i < name.length; i++) {
        if (i != 0 && !(name[i] >= 'a' && name[i] <= 'z')) return false;
        else if (i == 0 && !(name[i] >= 'A' && name[i] <= 'Z')) return false;
    }
    return true;
}
function checkEmail(email) {
    if (email.indexOf('@') == -1 || email.indexOf('@') == 0 ||
        email.indexOf('.') == -1 || email.indexOf('.') == email.length - 1 ||
        email.indexOf('@') > email.indexOf('.') || email.indexOf('.') - email.indexOf('@') == 1) return false;
    else return true;
}
function checkKey(key) {
    if (key.length < 6 || key.length > 10) return false;
    if (key.indexOf('!') == -1 && key.indexOf('@') == -1 && key.indexOf('#') == -1 && key.indexOf(',') == -1 && key.indexOf('.') == -1) return false;
    var small = 0;
    var large = 0;
    var digit = 0;
    for (var i = 0; i < key.length; i++) {
        if (key[i] >= 'a' && key[i] <= 'z') small++;
        else if (key[i] >= 'A' && key[i] <= 'Z') large++;
        else if (key[i] >= '0' && key[i] <= '9') digit++;
    }
    if (small == 0 || large == 0 || digit == 0) return false;
    return true;
}
//-----------
//Label color
//-----------
function labelName() {
    var name = document.getElementById("name").value;
    var labelName = document.getElementById("labelName");
    if (checkName(name)) labelName.style.color = "lightgreen";
    else labelName.style.color = "red";
}
function labelSurname() {
    var surname = document.getElementById("surname").value;
    var labelSurname = document.getElementById("labelSurname");
    if (checkName(surname)) labelSurname.style.color = "lightgreen";
    else labelSurname.style.color = "red";
}
function labelEmail() {
    var email = document.getElementById("email").value;
    var labelEmail = document.getElementById("labelEmail");
    if (checkEmail(email)) labelEmail.style.color = "lightgreen";
    else labelEmail.style.color = "red";
}
function labelKey() {
    var key = document.getElementById("key").value;
    var labelKey = document.getElementById("labelKey");
    if (checkKey(key)) labelKey.style.color = "lightgreen";
    else labelKey.style.color = "red";
}
//-----------
//Submit form
//-----------
function submitForm() {
    var name = document.getElementById("name").value;
    var surname = document.getElementById("surname").value;
    var email = document.getElementById("email").value;
    var key = document.getElementById("key").value;
    if (checkName(name)) {
        if (checkName(surname)) {
            if (checkEmail(email)) {
                if (checkKey(key)) {
                    alert("Everything's good!");
                    return true;
                }
                else {
                    alert("Invalid authentication key!");
                    return false;
                }
            }
            else {
                alert("Invalid email!");
                return false;
            }
        }
        else {
            alert("Invalid surname!");
            return false;
        }
    }
    else {
        alert("Invalid name!");
        return false;
    }
}