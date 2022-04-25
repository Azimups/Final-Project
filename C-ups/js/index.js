var navbar = document.getElementById('nav');
window.addEventListener("scroll",function(){
    if (window.scrollY>0) {
        navbar.classList.add("sticky");
    }
    else{
        navbar.classList.remove("sticky");
    }
})