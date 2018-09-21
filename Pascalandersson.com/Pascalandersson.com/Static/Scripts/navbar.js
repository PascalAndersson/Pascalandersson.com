
$(window).scroll(function () {
    displayScrolledNavbar();
});

function displayScrolledNavbar() {
    var heroImageHeight = $("#heroImage").height();
    var navbarContainer = $(".navbar__container");

    if ($(window).scrollTop() > (heroImageHeight - 80)) {
        $(navbarContainer).addClass("scrolled-down");
    } else {
        $(navbarContainer).removeClass("scrolled-down");
    } 
}