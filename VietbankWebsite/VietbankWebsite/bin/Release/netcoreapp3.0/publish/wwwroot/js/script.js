$(document).ready(function(){

    // jQuery methods go here...

    //fixed header
    $(window).scroll(function(){
      // var sticky = $('header'),
      var sticky = $('#sticky'),

        scroll = $(window).scrollTop();
        if (scroll >= 100) sticky.addClass('fixed');
          else sticky.removeClass('fixed');
    });

    // function header() {   
    //         hd = $('#header');

    //         if ($('#panel').length >0){ hPanel = $('#panel').height(); }else{ hPanel = 0; }

    //         if(hd.hasClass('fixe')){
    //             hh = hd.height();
    //             afterHeader = $('<div class="afterHeader"> ');
    //             hd.after(afterHeader.height(hh));  
    //             $(window).scroll(function() {
    //                 if ($(window).scrollTop() > hPanel) {
    //                     hd.addClass('sticky');
    //                 }
    //                 else{
    //                     hd.removeClass('sticky');
    //                 }
    //             });

    //         }
    // }

    function header() {   
        hd = $('#header');

        if ($('#panel').length >0){ hPanel = $('#panel').height(); }else{ hPanel = 0; }

        var topNav = $('#myTopnav').offset().top;

        if(hd.hasClass('fixe')){
            hh = hd.height();
            // afterHeader = $('<div class="afterHeader"> ');
            afterHeader = $('.afterHeader');

            hd.after(afterHeader.height(hh));  
            $(window).scroll(function() {
                if ($(window).scrollTop() > hPanel) {
                    hd.addClass('sticky');
                    // $('#panel .widget-mini-cart').removeClass('active');
                }
                else{
                    hd.removeClass('sticky');
                   
                }

                if(screen.width > 767){
                   if($(window).scrollTop() > topNav){
                    $('.menu-wrap').addClass('fixed');
                    var top =  hd.outerHeight();
                    $('.menu-wrap').css('top',top);
                    console.log(top);
                  }
                  else{
                    $('.menu-wrap').removeClass('fixed');
                    $('.menu-wrap').css('top','auto');
                  }
                }
            
            });
          
        }
    }

    //menu top 
    $('.top-menu ul li').click(function() {
        $('.current').removeClass('current');
        $(this).addClass('current');
      });

    // button search 
    var $searchTrigger = $('[data-ic-class="search-trigger"]'),
    $searchInput = $('[data-ic-class="search-input"]'),
    $searchClear = $('[data-ic-class="search-clear"]');
    $searchTrigger.click(function(){
      var $this = $('[data-ic-class="search-trigger"]');
      $this.addClass('active');
      $searchInput.focus();
    });

    $searchInput.blur(function(){
      if($searchInput.val().length > 0){
        return false;
      } 
      else {
              $searchTrigger.removeClass('active');
            }
    });

    $searchClear.click(function(){
      $searchInput.val('');
    });
    $searchInput.focus(function(){
      $searchTrigger.addClass('active');
    });
    
    // menu section breadcrumb-wrap
    $('.breadcrumb-wrap ol li').click(function(){
      $('.active').removeClass('active');
      $(this).addClass('active');
    });

    
    //menu horizonetal
    $('.menu-wrap ul li').click(function() {
      $('.active').removeClass('active');
      $(this).addClass('active');
    });

     //reponsive
     $('.js-toggle-menu').click(function(e){
      e.preventDefault();
      $('.menu-horizontal').slideToggle();
      $(this).toggleClass('open');
    });
    
    $(".menu-wrap a[href^='#']").click(function(e) {
      e.preventDefault();
      
      var position = $($(this).attr("href")).offset().top -130 ;
      $('.menu-wrap').addClass('fixed');
    
      $("body, html").animate({
        scrollTop: position
      }, 1000 );
    });
         

    //slides swiper
    var swiper = new Swiper('.swiper-container', {
      slidesPerView: 1,
      spaceBetween: 10,
      centeredSlides: false,
      // init: false,
      pagination: {
        el: '.swiper-pagination',
        clickable: true,
      },
      navigation: {
        nextEl: '.swiper-button-next',
        prevEl: '.swiper-button-prev',
      },
      breakpoints: {
        640: {
          slidesPerView: 1,
          spaceBetween: 20,
        },
        768: {
          slidesPerView: 2,
          spaceBetween: 30,
        },
        1024: {
          slidesPerView: 3,
          spaceBetween: 40,
        },
      }
    });

    $(document).ready(function(){
      header();
    });

});