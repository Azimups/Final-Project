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
    console.log("s");
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
    changeRegisterBtn.style.color="#ee5827";
    changeLoginBtn.style.color="#999";
})
changeLoginBtn.addEventListener("click", function(){
    changeLoginHeader.classList.add("register-active")
    changeRegisterHeader.classList.remove("register-active");
    navbar.classList.add("nav-black");
    changeLoginBtn.style.color="#ee5827";
    changeRegisterBtn.style.color="#999";
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
    RightBar.style.display = "none";
})
const overlayCloseBtn = document.getElementById('overlay-close')
overlayCloseBtn.addEventListener("click", function(){
    overlayMenu.classList.remove("menu-opened")
    RightBar.style.display = "block";
    navbar.classList.remove("nav-black");
})
const RightBar = document.getElementById('right-bar')
const cardBtn = document.getElementById('cart-btn')

$(document).ready(function(){
    $("#product-content").hide();
});
$("#open-info-btn").click(function(){
    $("#product-content").toggle("slow")
    console.log("s");
})
$("#open-question-btn").click(function(){
    $("#product-question").toggle("slow")
})

const groundImgLittle = document.getElementById('ground-img')
const groundImgBig = document.getElementById('ground-img-big')
const mainImg = document.getElementById('main-img')
if (groundImgLittle!==null) {
    groundImgLittle.addEventListener("click",function() {
        mainImg.src=groundImgBig.src;
        groundImgLittle.style.border = "1px solid black";
        beanImg.style.border = "none";
    })
}
else{
    console.log("wrong");
}

const beanImg = document.getElementById('bean-img-little')
const beanImgBig = document.getElementById('bean-img-big')
if (beanImg!==null) {
    beanImg.addEventListener("click",function() {
        mainImg.src = beanImgBig.src;
        beanImg.style.border = "1px solid black"
        groundImgLittle.style.border = "none"
    })
}
else{
    console.log("wrong");
}
const beanChangeBtn = document.getElementById('bean-change-btn')
const groundChangeBtn = document.getElementById('ground-change-btn')
if (beanImg!==null) {
    beanChangeBtn.addEventListener("click",function() {
        mainImg.src = beanImgBig.src;
        beanChangeBtn.classList.add("label-active")
        groundChangeBtn.classList.remove("label-active")
        beanImg.style.border = "1px solid black"
        groundImgLittle.style.border = "none"
    })
}
else{
    console.log("wrong");
}
if (groundChangeBtn!==null) {
    groundChangeBtn.addEventListener("click",function(){
        mainImg.src=groundImgBig.src;
        groundChangeBtn.classList.add("label-active")
        beanChangeBtn.classList.remove("label-active")
        groundImgLittle.style.border = "1px solid black";
        beanImg.style.border = "none";
    })
}
else{
    console.log("wrong");
}
window.addEventListener("scroll",reveal);
function reveal(){
    var reveals = document.querySelectorAll(".reveal");
    for (let index = 0; index < reveals.length; index++) {
        var windowHeight = window.innerHeight;
        var revealTop  = reveals[index].getBoundingClientRect().top;
        var revealPoint = 150;
        if (revealTop<windowHeight-revealPoint) {
            reveals[index].classList.add("make-visible")
        }
        else{
            reveals[index].classList.remove("make-visible")
        }
        
    }
}

var loader = document.getElementById('pre-loader');
$(window).on("load",function(){
    $("#pre-loader").delay(1000).fadeOut("slow");
});