
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