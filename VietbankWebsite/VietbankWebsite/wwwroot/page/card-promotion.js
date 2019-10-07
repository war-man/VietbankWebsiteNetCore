(function () {
    getCardPromotionPostDefault();
})();

function getCardPromotionPostDefault() {
    requestAjaxGet('/api/ApiCard/getpromotionpost/0/6')
        .done(function (data) {
            $('#sale-list').html(loopListPromotion(data.post));
            generatePagination(data.pageSize);
        }).fail(function (error) {
            console.log(error);
        });
}

function getCardPromotionPost(pageCurrent) {
    requestAjaxGet('/api/ApiCard/getpromotionpost/' + pageCurrent + '/6')
        .done(function (data) {
            $('#sale-list').html(loopListPromotion(data.post));
        }).fail(function (error) {
            console.log(error);
        });
}

function loopListPromotion(list) {
    var listPost = '';
    for (var i = 0; i < list.length; i++) {
        listPost += generatePostItem(list[i]);
    }
    return listPost;
}

function generatePostItem(promotion) {
    var post = '<div class="sale">' +
        '<figure><a class="sale-img" href="' + promotion.url + '"><img class="lazyload" data-src="' + promotion.pathThumbNail + '" src="' + promotion.pathThumbNail + '" alt=""></a>' +
        '<figcaption>' +
        '<h2 class="sale-name"> <a href="' + promotion.url + '">' + promotion.title + '</a></h2>' +
        '<div class="sale-des">' + promotion.description + '</div>' +
        '<div class="sale-btn"><a class="btn-viewdetail" href="' + promotion.url + '">Xem chi tiết</a></div>' +
        '</figcaption>' +
        '</figure>' +
        '</div>';
    return post;
}

function generatePagination(numpage) {
    if (numpage > 0) {
        var pagination = '';
        for (var i = 0; i < numpage; i++) {
            if (i == 0) {
                pagination += '<li data-page-current="'+i+'" class="active"><a href="#!">'+(i+1)+'</a></li>';
            } else {
                pagination += '<li data-page-current="' + i +'"><a href="#!">' + (i + 1) +'</a></li>';
            }
        }
        $('#pagination').html(pagination);
        initialPaginationClick();
    }
}

function initialPaginationClick() {
    $('#pagination li').click(function () {
        $('#pagination li').each(function () {
            $(this).removeClass('active');
        });
        $(this).addClass('active');
        getCardPromotionPost($(this).attr('data-page-current'));
    });
}