
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

function openNav() {
    document.getElementById("navSidebar").style.width = "100%";
    document.getElementById("navSidebar").style.maxWidth = "400px";
    document.getElementById("main").style.marginLeft = "250px";
}

function closeNav() {
    document.getElementById("navSidebar").style.width = "0";
    document.getElementById("main").style.marginLeft = "0";
}

//Open and close shopping-cart
function openCart() {
    document.getElementById("cart").classList.add("open")
}

function closeCart() {
    document.getElementById("cart").classList.remove("open");
}


// ADD TO CART FUNCTIONS
var productsList;

document.addEventListener('DOMContentLoaded', function refreshCart() {
    let products = getCookie("ProductsCookie");
    productsList = JSON.parse(products);

    let quantityCount = 0;

    for (let i = 0; i < productsList.length; i++) {
        console.log(productsList[i].ProductName)
        let newProductElement = createCartProduct(productsList[i]);

        quantityCount += productsList[i].Quantity;

        let element = document.createElement('div');
        element.innerHTML = newProductElement;
        let cartBasket = document.querySelector('.cart-content');
        cartBasket.append(element);

    }

    cartCount(quantityCount);
    loadContent();
    updateTotal();

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

function cartCount(quantityCount) {
    let cartCount = document.getElementById('cart-count').innerText
    cartCount = quantityCount;
    document.getElementById('cart-count').innerText = cartCount;
}


function createCartProduct(product) {

    if (product.DiscountedPrice > 0 ) {
        return `
        <div class="cart-box" data-product-id="${product.ProductId}">
            <img src="${product.ImageUrl}" class="cart-img">
            <div class="detail-box">
                <div class="cart-product-title">${product.ProductName} ${product.Size} ${product.Color}</div>
                <div class="price-box">
                    <div class="cart-price">$${product.DiscountedPrice} x ${product.Quantity} </div>
                    <div class="cart-amt">${product.DiscountedPrice}</div>
                    <div class=""><i class="cart-remove fa-regular fa-trash-can"></i></div>
                </div>
                <input type="number" value="${product.Quantity}" class="add-cart cart-quantity" min="1">
            </div>
        </div>
    `;
    }

    return `
        <div class="cart-box" data-product-id="${product.ProductId}">
            <img src="${product.ImageUrl}" class="cart-img">
            <div class="detail-box">
                <div class="cart-product-title">${product.ProductName} ${product.Size} ${product.Color}</div>
                <div class="price-box">
                    <div class="cart-price">$${product.Price} x ${product.Quantity} </div>
                    <div class="cart-amt">${product.Price}</div>
                    <div class=""><i class="cart-remove fa-regular fa-trash-can"></i></div>
                </div>
                <input type="number" value="${product.Quantity}" class="add-cart cart-quantity" min="1">
            </div>
        </div>
    `;
 
}

const btnCart = document.querySelector('#cart-icon');
const cart = document.querySelector('.cart');

function loadContent() {
    //Remove items from Cart
    let btnRemove = document.querySelectorAll('.cart-remove');
    btnRemove.forEach((btn) => {
        btn.addEventListener('click', removeItem);
    });

    //Add items to Cart
    let cartBtns = document.querySelectorAll('.add-cart');
    cartBtns.forEach((btn) => {
        btn.addEventListener('click', addToCart);
    });
}


var cookieOptions = {
    SameSite: "Strict",
    Secure: true,
    IsEssential: true,
    Path: "/"
};
function removeItem() { 
    if (confirm('Remove product?')) {
        let productBox = this.closest('.cart-box');
        if (productBox) {
            let productId = productBox.getAttribute('data-product-id');

            productsList = productsList.filter(product => product.ProductId !== productId);

            var encodedProductsList = encodeURIComponent(JSON.stringify(productsList));
            document.cookie = "ProductsCookie=" + encodedProductsList + "; path=" + cookieOptions.Path + "; SameSite=" + cookieOptions.Samesite + "; Secure=" + cookieOptions.Secure+ "; IsEssential=" + cookieOptions.IsEssential;

            saveSidebarState();
            location.reload();
        }
    }
}

function addToCart() {
    let productId = this.parentElement.parentElement.getAttribute('data-product-id');
    let newQuantity = parseInt(this.value);

    // Check if the quantity is updated
    let isQuantityUpdated = false;
    for (let i = 0; i < productsList.length; i++) {
        if (productsList[i].ProductId === productId && productsList[i].Quantity !== newQuantity) {
            productsList[i].Quantity = newQuantity;
            isQuantityUpdated = true;
            break;
        }
    }

    if (isQuantityUpdated) {

        //var cookieOptions = {
        //    SameSite: "Strict",
        //    Secure: true,
        //    IsEssential: true,
        //    Path: "/"
        //};

        var encodedProductsList = encodeURIComponent(JSON.stringify(productsList));
        document.cookie = "ProductsCookie=" + encodedProductsList + "; path=" + cookieOptions.Path + "; SameSite=" + cookieOptions.Samesite + "; Secure=" + cookieOptions.Secure + "; IsEssential=" + cookieOptions.IsEssential;

        saveSidebarState();
        location.reload();
    }
}



//Cart sidebar stays open after update
function saveSidebarState() {
    let sidebar = document.querySelector('.cart');
    let isSidebarOpen = sidebar.classList.contains('open');
    sessionStorage.setItem('isSidebarOpen', isSidebarOpen);
}

window.addEventListener('beforeunload', saveSidebarState);

document.addEventListener('DOMContentLoaded', function () {
    let isSidebarOpen = sessionStorage.getItem('isSidebarOpen');
    let sidebar = document.querySelector('.cart');

    if (isSidebarOpen === 'true') {
        sidebar.classList.add('open');
    } else {
        sidebar.classList.remove('open');
    }
});

//Update total value of items
function updateTotal() {
    const cartItems = document.querySelectorAll('.cart-box');
    const totalValue = document.querySelector('.total-price');

    let total = 0;

    cartItems.forEach(product => {
        let priceElement = product.querySelector('.cart-price');
        let price = parseFloat(priceElement.innerHTML.replace("$", ""));
        let qty = product.querySelector('.cart-quantity').value;
        total += (price * qty);
        product.querySelector('.cart-amt').innerText = "$" + (price * qty);

    });

    totalValue.innerHTML = '$' + total;
}

