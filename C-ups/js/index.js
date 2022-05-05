const navbar = document.getElementById('nav');
window.addEventListener("scroll",function(){
    if (window.scrollY>0) {
        navbar.classList.add("sticky");
    }
    else{
        navbar.classList.remove("sticky");
    }
})
const searchPopup = document.getElementById('search-box');
const searchBtn = document.getElementById('search-btn');
searchBtn.addEventListener("click",function(){
    searchPopup.classList.toggle("search-active");
    navbar.classList.add("nav-black");
    registerHeader.classList.remove("register-active")
    changeLoginHeader.classList.remove("register-active")
})
window.addEventListener("click",({target}) =>{
    const popup = target.closest('.search-popup');
    const container = target.closest('.container')
    const clickedOnClosedPopup = popup && !popup.classList.contains("search-active");
    if (!clickedOnClosedPopup) {
        return;
    }
})
const registerHeader = document.getElementById('register-header');
const changeLoginHeader = document.getElementById('login-form-header');
const changeLoginBtn = document.getElementById('change-form-login');
const userBtn = document.getElementById('user-btn');
const closeLoginBtn = document.getElementById('close-login-btn');
userBtn.addEventListener("click", function(){
    registerHeader.classList.add("register-active")
    changeLoginHeader.classList.add("register-active")
    navbar.classList.add("nav-black");
    changeRegisterHeader.classList.remove("register-active");
    searchPopup.classList.remove("search-active");
})

closeLoginBtn.addEventListener("click", function(){
    registerHeader.classList.remove("register-active")
    navbar.classList.remove("nav-black");
})
const changeRegisterHeader = document.getElementById('register-form-header');
const changeRegisterBtn = document.getElementById('change-form-register');

changeRegisterBtn.addEventListener("click",function() {
    changeRegisterHeader.classList.add("register-active");
    navbar.classList.add("nav-black");
    changeLoginHeader.classList.remove("register-active")
})
changeLoginBtn.addEventListener("click", function(){
    changeLoginHeader.classList.add("register-active")
    changeRegisterHeader.classList.remove("register-active");
    navbar.classList.add("nav-black");
})
const closeRegisterBtn = document.getElementById('close-register-btn');
closeRegisterBtn.addEventListener("click", function(){
    registerHeader.classList.remove("register-active")
    navbar.classList.remove("nav-black");
    changeRegisterHeader.classList.remove("register-active");
})

const openMenuBtn = document.getElementById('menu-btn');
const overlayMenu = document.getElementById('overlay-menu')
openMenuBtn.addEventListener("click",function() {
    overlayMenu.classList.add("menu-opened")
    navbar.classList.add("nav-black");
    changeLoginHeader.classList.add("register-active")
    changeRegisterHeader.classList.remove("register-active");
    navbar.style.display="none";
})
const overlayCloseBtn = document.getElementById('overlay-close')
overlayCloseBtn.addEventListener("click", function(){
    overlayMenu.classList.remove("menu-opened")
    navbar.style.display="block";
    navbar.classList.remove("nav-black");
})
const RightBar = document.getElementById('right-bar')
const cardBtn = document.getElementById('cart-btn')
const BasketBox = document.getElementById('basket-box')
cardBtn.addEventListener("click",function(){
    BasketBox.classList.add("basket-opened");
    RightBar.style.display = "none";
    $("body").css("overflow", "hidden");
})

const closeCardBtn = document.getElementById('close-box')
closeCardBtn.addEventListener("click",function() {
    BasketBox.classList.remove("basket-opened");
    RightBar.style.display = "block";
    $("body").css("overflow", "visible");
})