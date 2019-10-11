// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function updateCartCount(count) {
    $("#cartNav").children('span').text(count);
}

// https:/ / stackoverflow.com / questions / 30293784 / smooth - scroll - to - anchor - after - loading - new- page
// to top right away
if (window.location.hash) scroll(0, 0);
// void some browsers issue
setTimeout(function () { scroll(0, 0); }, 1);

$(function () {
    // *only* if we have anchor on the url
    if (window.location.hash) {

        // smooth scroll to the anchor id
        $('html, body').animate({
            scrollTop: $(window.location.hash).offset().top + 'px'
        }, 500, 'swing');
    }

});
