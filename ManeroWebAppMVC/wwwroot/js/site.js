
//Methods for Product page.
function increaseAmount() {
    let currentAmount = parseInt($("#current-amount").text());
    currentAmount++;
    $("#current-amount").text(currentAmount);
    $("#current-amount-input").val(currentAmount);
}
function decreaseAmount() {
    let currentAmount = parseInt($("#current-amount").text());
    if (currentAmount > 0) {
        currentAmount--;
        $("#current-amount").text(currentAmount);
        $("#current-amount-input").val(currentAmount);
    }
}
function selectThisSize(size) {
    $("#selected-size").val(size);

    addSelectedForButton(`size-${size}`, `size-buttons`, `size-button`);
}
function selectThisColor(color) {
    $("#selected-color").val(color);

    addSelectedForButton(`color-${color}`, `color-buttons`, `color-button`);
}

function addSelectedForButton(target, containerId, className) {
    let container = document.getElementById(containerId);

    let btns = container.getElementsByClassName(className)
    for (var i = 0; i < btns.length; i++) {
        if (btns.item(i).classList.contains("selected")) {
            btns.item(i).classList.remove("selected");
        }
    }
    document.getElementById(target).classList.add("selected");
}

/* Add active class to the current selected Main Category button (highlight it)*/
//var header = document.getElementById("mc-btns");
//var btns = header.getElementsByClassName("main-categories-nav-box-btn");
//for (var i = 0; i < btns.length; i++) {
//    btns[i].addEventListener("click", function () {
//        var current = document.getElementsByClassName("active");
//        current[0].className = current[0].className.replace(" active", "");
//        this.className += " active";
//    });
//}



//Open and close sidebar nav
function openNav() {
    document.getElementById("navSidebar").style.width = "80%";
    document.getElementById("main").style.marginLeft = "250px";
}

function closeNav() {
    document.getElementById("navSidebar").style.width = "0";
    document.getElementById("main").style.marginLeft = "0";
}
