$(function () {
    $('#sideNavBtn').on('click', function () {
        toggleNavbar();
    });
});

$(window).scroll(function () {
    displayScrolledNavbar();
});

function displayScrolledNavbar() {
    var heroImageHeight = $("#heroImage").height();
    var navbarContainer = $(".navbar__container");

    if ($(window).scrollTop() > (heroImageHeight - 700)) {
        $(navbarContainer).addClass("scrolled-down");
    } else {
        $(navbarContainer).removeClass("scrolled-down");
    }
}

function toggleNavbar() {
    var sideNav = $('#navbarSideNav');

    if (sideNav.hasClass('active')) {
        $('#sideNavBtn').html("<i class='fas fa-bars'></i>");
        sideNav.removeClass('active');
    } else {
        $('#sideNavBtn').html("<i class='fas fa-times'></i>");
        sideNav.addClass('active');
    }
}