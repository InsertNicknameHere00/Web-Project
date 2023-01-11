function sub() {
    var speed = document.getElementById("speed").value;
    var work = document.getElementById("work").value;
    var att = document.getElementById("att").value;
    var average = speed / 3 + work / 3 + att / 3;
    alert("Thanks for your time!\nSpeed: " + speed + "\nAttitude: " + att + "\nWork done: " + work + "\nAverage rating: " + average.toFixed(2));
    document.getElementById("form").submit();
}