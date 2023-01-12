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
        email.indexOf('@') > email.indexOf('.') || email.indexOf('.')-email.indexOf('@')==1) return false;
    else return true;
}
function checkPhone(phone) {
    if (phone[0] != 0 || phone[1] != 8 || (phone[2] != 7 && phone[2] != 8 && phone[2] != 9) || phone.length != 10) return false;
    else return true;
}
function checkDate(date) {
    var date = new Date(document.getElementById("date").value);
    const d = new Date();
    var day = d.getDate();
    var month = d.getMonth() + 1;
    var year = d.getFullYear();
    var today = new Date(year + "-" + month + "-" + day);
    var oneDay = 1000 * 60 * 60 * 24;
    var diffInTime = date.getTime() - today.getTime();
    var diffInDays = diffInTime / oneDay;
    console.log(today);
    if (diffInDays <= 0 || diffInDays > 30 || date.getDay() == 0 || date.getDay() == 6) return false;
    else return true;
}
function checkHour(hour, minutes) {
    if (hour < 8 || hour > 16 || (hour == 16 && minutes != 0)) return false;
    else return true;
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
function labelPhone() {
    var phone = document.getElementById("phone").value;
    var labelPhone = document.getElementById("labelPhone");
    if (checkPhone(phone)) labelPhone.style.color = "lightgreen";
    else labelPhone.style.color = "red";
}
function labelDate() {
    var date = document.getElementById("date").value;
    var labelDate = document.getElementById("labelDate");
    if (checkDate(date)) labelDate.style.color = "lightgreen";
    else labelDate.style.color = "red";
}
function labelHour() {
    var hour = document.getElementById("hour").value;
    var minutes = document.getElementById("minutes").value;
    var labelHour = document.getElementById("labelHour");
    var labelMinutes = document.getElementById("labelMinutes");
    if (checkHour(hour, minutes)) {
        labelHour.style.color = "lightgreen";
        labelMinutes.style.color = "lightgreen";
    }
    else {
        labelHour.style.color = "red";
        labelMinutes.style.color = "red";
    }
}
//---------------
//Submit function
//---------------
function submitForm() {
    var name = document.getElementById("name").value;
    var surname = document.getElementById("surname").value;
    var email = document.getElementById("email").value;
    var phone = document.getElementById("phone").value;
    var date = document.getElementById("date").value;
    var hour = document.getElementById("hour").value;
    var minutes = document.getElementById("minutes").value;
    var form = document.getElementById("form");
    if (checkName(name)) {
        if (checkName(surname)) {
            if (checkEmail(email)) {
                if (checkPhone(phone)) {
                    if (checkDate(date)) {
                        if (checkHour(hour, minutes)) {
                            return true;
                        }
                        else {
                            alert("Invalid hour!");
                            return false;
                        }
                    }
                    else {
                        alert("Invalid date!");
                        return false;
                    }
                }
                else {
                    alert("Invalid phone number!");
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