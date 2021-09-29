$(window).scroll(function () {
    $('.navbar').toggleClass('scrolled', $(this).scrollTop() > 50)
})


$(window).scroll(function () {
    $('a').toggleClass('scrolled', $(this).scrollTop() > 50)
})

//$(".scroll").on('click', function (event) {
//    event.preventDefault();
//    var hash = this.hash;
//    var headerHeight = $("header").height();

//    $('html, body').animate({
//        scrollTop: ($(hash).offset().top - headerHeight)
//    }, "fast", function () {
//        window.location.hash = hash;
//    });
//});


//window.onload = function () {
//    scrollSpy('#main-menu', {
//        sectionClass: '.scrollspy',
//        menuActiveTarget: '.nav-link',
//        offset: 100,
//    })
//}



$('[data-fancybox="gallery"]').fancybox({
    buttons: [
        "zoom",
        //"share",
        "slideShow",
        //"fullScreen",
        //"download",
        "thumbs",
        "close"
    ],
});



var slider = tns({
    container: '.my-slider',
    slideBy: 'page',
    controlsContainer: '#custom-control',
    loop: false,
    rewind: true,
    swipeAngle: true,
    gutter: 30,
    speed: 200,
    navPosition: 'bottom',
    mouseDrag: true,
    autoplay: false,
    autoplayButtonOutput: false,
    responsive: {
        0: {
            items: 1,
            nav: false
        },
        768: {
            items: 2,
            nav: true,
        },
        1440: {
            items: 3
        }
    }
})