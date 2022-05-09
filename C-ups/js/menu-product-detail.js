const hiddenImageKicker = document.getElementById("hidden-image-kicker")
const hiddenImageBlended = document.getElementById("hidden-image-blended")
const detailMainImage = document.getElementById("detail-main-img")
const hiddenImageIced = document.getElementById("hidden-image-iced")
const drinkType1 = document.querySelector("[data-id='type-1']")
const recipe1 = document.querySelector("[data-id='recipe-1']")
drinkType1.addEventListener("click",function(){
    detailMainImage.src = hiddenImageIced.src
    drinkType1.classList.add("type-active")
    drinkType3.classList.remove("type-active")
    drinkType2.classList.remove("type-active")
    recipe1.classList.add("recipe-active")
    recipe2.classList.remove("recipe-active")
    recipe3.classList.remove("recipe-active")
})
const drinkType2 = document.querySelector("[data-id='type-2']")
const recipe2 = document.querySelector("[data-id='recipe-2']")
drinkType2.addEventListener("click",function(){
    detailMainImage.src = hiddenImageKicker.src;
    drinkType3.classList.remove("type-active")
    drinkType2.classList.add("type-active")
    drinkType1.classList.remove("type-active")
    recipe2.classList.add("recipe-active")
    recipe1.classList.remove("recipe-active")
    recipe3.classList.remove("recipe-active")
})
const drinkType3 = document.querySelector("[data-id='type-3']")
const recipe3 = document.querySelector("[data-id='recipe-3']")
drinkType3.addEventListener("click",function(){
    detailMainImage.src = hiddenImageBlended.src
    drinkType3.classList.add("type-active")
    drinkType1.classList.remove("type-active")
    drinkType2.classList.remove("type-active")
    recipe3.classList.add("recipe-active")
    recipe1.classList.remove("recipe-active")
    recipe2.classList.remove("recipe-active")
})

detailMainImage.addEventListener("click",function(){
    console.log(hiddenImageKicker);
})