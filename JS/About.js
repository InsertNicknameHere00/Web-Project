function changeMap(option) {
    var map = document.getElementById("map");
    if (option == 1) map.src = "https://www.google.com/maps/place/42%C2%B008'47.4%22N+24%C2%B043'37.9%22E/@42.1465,24.7271944,18z/data=!3m1!4b1!4m6!3m5!1s0x0:0xcbff25b9968b356!7e2!8m2!3d42.1464854!4d24.7272055?hl=bg";
    else if (option == 2) map.src = "https://goo.gl/maps/xdkQUFfC4qf4H3YbA";
    else map.src = "https://goo.gl/maps/jKhiUeRtQeTcEXJTA";
}