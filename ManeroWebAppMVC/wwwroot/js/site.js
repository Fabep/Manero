
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

//Open and close shopping-cart
function openCart() {
    document.getElementById("cart").style.width = "100%";
    document.getElementById("main").style.marginRight = "100px";
}

function closeCart() {
    document.getElementById("cart").style.width = "0";
    document.getElementById("main").style.marginRight = "0";
}




const btnCart = document.querySelector('#cart-icon');
const cart = document.querySelector('.cart');


//Add to cart
//function addToCart() {
//    let cartCount = document.getElementById('cart-count').innerText
//    cartCount++;
//    document.getElementById('cart-count').innerText = cartCount;
//}


function loadContent() {
    //RemoveItems  From Cart
    let btnRemove = document.querySelectorAll('.cart-remove');
    btnRemove.forEach((btn) => {
        btn.addEventListener('click', removeItem);
    });

    //Product Item Change Event
    let qtyElements = document.querySelectorAll('.cart-quantity');
    qtyElements.forEach((input) => {
        input.addEventListener('change', changeQty);
    });

    //Product Cart

    let cartBtns = document.querySelectorAll('.add-cart');
    cartBtns.forEach((btn) => {
        btn.addEventListener('click', addCart);
    });

    updateTotal();
}



//function addCart() {
//    let product = this.parentElement;
//    let title = product.querySelector('.product-name').innerHTML;
//    let price = product.querySelector('.product-price').innerHTML;
//    let imgSrc = product.querySelector('.product-img').src;
//    console.log(title,price,imgSrc);

//    let newProduct = { title, price, imgSrc }


//    itemList.push(newProduct);
//}


// Add a click event listener to the "buy" icon




function updateTotal() {
    const cartItems = document.querySelectorAll('.cart-box');
    const totalValue = document.querySelector('.total-price');

    let total = 0;

    cartItems.forEach(product => {
        let priceElement = product.querySelector('.cart-price');
        let price = parseFloat(priceElement.innerHTML.replace("Rs.", ""));
        let qty = product.querySelector('.cart-quantity').value;
        total += (price * qty);
        product.querySelector('.cart-amt').innerText = "Rs." + (price * qty);

    });

    totalValue.innerHTML = 'Rs.' + total;

}