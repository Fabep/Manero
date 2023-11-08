﻿
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



// ADD TO CART FUNCTIONS


//function getCookieValue(name) {
//    const value = ${ document.cookie };
//    const parts = value.split(; ${ name }=);
//    if (parts.length === 2) return parts.pop().split(';').shift();
//}

//function getCookie(name) {
//    const cookieString = document.cookie;
//    const cookies = cookieString.split(';');
//    for (let i = 0; i < cookies.length; i++) {
//        let cookie = cookies[i];
//        while (cookie.charAt(0) === ' ') {
//            cookie = cookie.substring(1);
//        }
//        if (cookie.indexOf(name + '=') === 0) {
//            return cookie.substring(name.length + 1, cookie.length);
//        }
//    }
//    return null;
//}


//const myProductCookie = document.cookie.split(';').find(cookie => cookie.includes('myProductCookie'));
//if (myProductCookie) {
//    const value = myProductCookie.split('=')[1];
//    console.log(value);
//} else {
//    console.log('Cookie not found.');
//}

document.addEventListener('DOMContentLoaded', function () {
    let products = getCookie("ProductsCookie");
    var productsList = JSON.parse(products);

    for (let i = 0; i < productsList.length; i++) {

        console.log(productsList[i].ProductName)
        let newProductElement = createCartProduct(productsList[i].ProductName, productsList[i].Price, productsList[i].Size, productsList[i].Color);

         let element = document.createElement('div');
        element.innerHTML = newProductElement;
        let cartBasket = document.querySelector('.cart-content');
        cartBasket.append(element);

        loadContent();

    }
});




function getCookie(cname) {
    let name = cname + "=";
    let decodedCookie = decodeURIComponent(document.cookie);
    let ca = decodedCookie.split(';');
    for (let i = 0; i < ca.length; i++) {
        let c = ca[i];
        while (c.charAt(0) == ' ') {
            c = c.substring(1);
        }
        if (c.indexOf(name) == 0) {
            return c.substring(name.length, c.length);
        }
    }
    return "";
}




function createCartProduct(title, price, size, color ) {

    return `
         <div class="cart-box">
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

//<img src="${imgSrc}" class="cart-img">


const btnCart = document.querySelector('#cart-icon');
const cart = document.querySelector('.cart');

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