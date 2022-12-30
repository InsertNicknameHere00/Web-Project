function sub() {
    var name = document.getElementById("name").value;
    var surname = document.getElementById("surname").value;
    var phone = document.getElementById("phone").value;
    var email = document.getElementById("email").value;
    var n = 0, s = 0, p = 0, e = 0;
    while (true) {
        if (n == 0) {
            for (var i = 0; i < name.length; i++) {
                if (!((name[i] >= 'a' && name[i] <= 'z') || (name[i] >= 'A' && name[i] <= 'Z'))) {
                    alert("Invalid name!");
                    break;
                }
            }
            n = 1;
        }
        else if (s == 0) {
            for (var i = 0; i < surname.length; i++) {
                if (!((surname[i] >= 'a' && surname[i] <= 'z') || (surname[i] >= 'A' && surname[i] <= 'Z'))) {
                    alert("Invalid surname!");
                    break;
                }
            }
            s = 1;
        }
        else if (p == 0) {
            if (phone[0] != 0 && phone[1] != 8 && phone.length != 10) {
                alert("Invalid phone number!");
                break;
            }
            if (phone[2] != 7 && phone[2] != 8 && phone[2] != 9) {
                alert("Invalid phone number!");
                break;
            }
            p = 1;
        }
        else if (e == 0) {
            if (/^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/.test(email))
                e = 1;
            else {
                alert("Invalid e-mail!");
                break;
            }
        }
        else {
            document.getElementById("form").submit();
        }
    }
}