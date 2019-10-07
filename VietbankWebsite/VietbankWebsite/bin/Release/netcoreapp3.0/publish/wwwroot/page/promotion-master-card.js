(function () {
    getCategoryMasterCard();
})();

function getCategoryMasterCard() {
    requestAjaxGet('/api/ApiCard/getcategorymastercard').done(function (data) {
        generateCategroyMasterCard(data);
    }).fail(function (error) {
        console.log(error);
    });
}

function generateCategroyMasterCard(category) {
    var cate = '';
    for (var i = 0; i < category.length; i++) {
        cate += '<li><a data-id="' + category[i].id + '" href="#!">' + category[i].name+'</a></li>';
    }
    $('#list-cate').html(cate);
    var idCate = $('#list-cate li:first-child a').attr('data-id');
    getListPostMasterCard(idCate, 0, 6);
    $('#list-cate li:first-child').addClass('active');
    initialCategoryMasterCardClick();
}

function initialCategoryMasterCardClick() {
    $('#list-cate li').click(function () {
        $('#list-cate li').removeClass('active');
        $(this).addClass('active');
        getListPostMasterCard($(this).find('a').attr('data-id'), 0, 6);
    });
}

function getListPostMasterCard(id, pageCurrent, pageSize) {
    requestAjaxGet('/api/ApiCard/getlistpostmastercard/' + id + '/' + pageCurrent + '/' + pageSize).done(function (data) {
        var postMasterCard = '';
        for (var i = 0; i < data.post.length; i++) {
            postMasterCard += generateItemMasterCard(data.post[i]);
        }
        $('#place-list').html(postMasterCard);
        generatePagination(data.pageNum);
    }).fail(function (error) {
        console.log(error);
    });
}

function getListPostMasterCardNoneGeneratePagination(id, pageCurrent, pageSize) {
    requestAjaxGet('/api/ApiCard/getlistpostmastercard/' + id + '/' + pageCurrent + '/' + pageSize).done(function (data) {
        var postMasterCard = '';
        for (var i = 0; i < data.post.length; i++) {
            postMasterCard += generateItemMasterCard(data.post[i]);
        }
        $('#place-list').html(postMasterCard);
    }).fail(function (error) {
        console.log(error);
    });
}

function generatePagination(numPage) {
    var pagination = '';
    for (var i = 0; i < numPage; i++) {
        pagination += '<li data-page="'+i+'"><a href="#!">'+(i+1)+'</a></li>';
    }
    $('#pagination').html(pagination);
    $('#pagination li:first-child').addClass('active');
    initialPaginationClick();
}

function initialPaginationClick() {
    $('#pagination li').click(function () {
        $('#pagination li').removeClass('active');
        $(this).addClass('active');
        getListPostMasterCardNoneGeneratePagination($('#list-cate li.active').find('a').attr('data-id'), $(this).attr('data-page'), 6)
    });
}

function generateItemMasterCard(item) {
    var masterCard = '<div class="col-12 col-md-6">'+
        '<div class="place">' +
        '<figure><a class="place-img" href="' + item.url + '"><img class="lazyload" data-src="' + item.thumbNail + '" src="' + item.thumbNail + '" alt="">' +
                '<div class="caption">'+
                    '<div class="text">'+
                        '<p>Áp dụng tất cả hệ thống trên toàn quốc</p>'+
                    '</div>'+
                '</div></a>'+
        '<figcaption>' +
        '<div class="place-name">' + item.title + '</div>' +
        '<div class="place-des">' + item.description + '</div>' +
                '</figcaption>'+
                    '</figure>'+
                  '</div>'+
        '</div >';
    return masterCard;
}