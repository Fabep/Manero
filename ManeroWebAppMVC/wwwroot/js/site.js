
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
}
function selectThisColor(color) {
    $("#selected-color").val(color);
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



// ADD TO CART FUNCTIONS
const btnCart = document.querySelector('#cart-icon');
const cart = document.querySelector('.cart');


//Add to cart
//function addToCart() {
//    let cartCount = document.getElementById('cart-count').innerText
//    cartCount++;
//    document.getElementById('cart-count').innerText = cartCount;
//}



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


let productList = [];

document.addEventListener('DOMContentLoaded', function () {
    const buyIcons = document.querySelectorAll('.fa-solid.fa-bag-shopping.buy');

    buyIcons.forEach(function (buyIcon) {
        buyIcon.addEventListener('click', function () {
            let productTile = this.closest('.product-tile');
            let title = productTile.querySelector('.product-name').innerText;
            let price = productTile.querySelector('.product-price').innerText;
            let imgSrc = productTile.querySelector('.product-image img').src;

            // Call the function to add the product to the list
            addProductToList(title, price, imgSrc);
        });
    });

    // Define the function to add the product to the list
    function addProductToList(title, price, imgSrc) {
        let newProduct = { title, price, imgSrc };

        productList.push(newProduct);
        console.log('Product added to the list:', newProduct);

        let newProductElement = createCartProduct(title, price, imgSrc);

        let element = document.createElement('div');
        element.innerHTML = newProductElement;
        let cartBasket = document.querySelector('.cart-content');
        cartBasket.append(element);

        loadContent();
    }
});


function createCartProduct(title, price, imgSrc) {

    return `
         <div class="cart-box">
                <img src="${imgSrc}" class="cart-img">
             <div class="detail-box">
                <div class="cart-food-title">${title}</div>
                <div class="price-box">
                      <div class="cart-price">${price}</div>
                      <div class="cart-amt">${price}</div>
                </div>
             <input type="number" value="1" class="cart-quantity">
             </div>
         </div>
           `;
}


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