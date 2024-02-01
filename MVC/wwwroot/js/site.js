
let menuIcon = document.getElementById("mobile-menu");

menuIcon.addEventListener("click", function () {
    let menu = document.getElementById("menu");
    if(menu.style.display != "block") {
        menu.style.display = "block";
    } else {
        menu.style.display = "none";
    }
})
