(function () {
    initialSearchInforChange();    
    initialDivToUpClick();
    initOnclickTagPreventDefault();
    initLazyLoad();
})();
var delay = (function () {
    var timer = 0;
    return function (callback, ms) {
        clearTimeout(timer);
        timer = setTimeout(callback, ms);
    };
})();
function initialSearchInforChange() {
    $('#search-infor').keyup(function () {
        if ($(this).val().length > 3) {
            $(this).parent().find('i').removeClass('fa fa-search').addClass('fa fa-close');
            $(this).parent().find('i').click(function () {
                $('#search-results').html(null);
                $(this).removeClass('fa fa-close').addClass('fa fa-search');
                $('#search-infor').val(null);
            });
            
            delay(function () {
                $.get('/api/home/search?key=' + $('#search-infor').val(), function (data) {
                    //console.log(data);
                    generateResultSearch(data)
                });
            }, 300);
        } else {
            $(this).parent().find('i').removeClass('fa fa-close').addClass('fa fa-search');
            $('#search-results').html(null);
        }
    });
}

function generateResultSearch(result) {
    var listResult = '<i class="list-group-item"><strong>' + result.length + ' </strong>kết quả tìm kiếm cho <b>“' + $('#search-infor').val() + '”</b></i>';
    for (var i = 0; i < result.length; i++) {
        listResult += '<a class="list-group-item" href="' + result[i].url + '"> <i class="zmdi zmdi-file-text"></i><span>' + result[i].title+'</span></a>';
    }
    $('#search-results').html(listResult);
}

function initialDivToUpClick() {
    $('div.up').click(function () {
        $(window).scrollTop(0);
    });
}
function initLazyLoad() {
    $("img.lazyload").lazyload();
}

function initOnclickTagPreventDefault() {
    $('li.dropdown a.dropdown-toggle').click(function (event) {
        event.preventDefault();
    });
}
