
function add() {
    let currentAmountElement = document.getElementById('current-amount');
    let currentAmount = parseInt(currentAmountElement.innerHTML);
    currentAmount++;
    currentAmountElement.innerHTML = currentAmount;
}
function remove() {
    let currentAmountElement = document.getElementById('current-amount');

    let currentAmount = parseInt(currentAmountElement.innerHTML);
    if (currentAmount > 0) {
        currentAmount--;
        currentAmountElement.innerHTML = currentAmount;
    }
}
// Add active class to the current selected Main Category button (highlight it)
var header = document.getElementById("mc-btns");
var btns = header.getElementsByClassName("main-categories-nav-box-btn");
for (var i = 0; i < btns.length; i++) {
    btns[i].addEventListener("click", function () {
        var current = document.getElementsByClassName("active");
        current[0].className = current[0].className.replace(" active", "");
        this.className += " active";
    });
}



//Open and close sidebar nav
function openNav() {
    document.getElementById("navSidebar").style.width = "80%";
    document.getElementById("main").style.marginLeft = "250px";
}

function closeNav() {
    document.getElementById("navSidebar").style.width = "0";
    document.getElementById("main").style.marginLeft = "0";
}
