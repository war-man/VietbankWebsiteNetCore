var isDrawedPagination = false;
(function () {
    getListProduct(0);
    activeLeftMenu();
})();

function getLastPathName() {
    var pathName = window.location.pathname;
    var slipPath = pathName.split('/');
    return slipPath[slipPath.length - 1];
}

function activeLeftMenu() {
    $('.left-menu a').each(function () {
        if ($(this).attr('href') === window.location.pathname)
            $(this).addClass('active');
    });
}

function getListProduct(page) {
    requestAjaxGet('/api/ApiPersonal/listproducttocategory/' + getLastPathName() + '/' + page + '/9').done(function (data) {
        $('#list-product').html(loopProduction(data.listProductShorts));
        if (!isDrawedPagination) {
            generatePagination(data.pageSize);
            isDrawedPagination = true;
        }
        
    }).fail(function (error) {
        console.log(error);
    });
}

function loopProduction(data) {
    var product = '';
    for (var i = 0; i < data.length; i++) {
        product += generateItem(data[i]);
    }
    return product;
}

function generateItem(product) {
    var item = '<div class="col-xs-12 col-md-4 col-lg-4 item-wrap">'+
                    '<div class="item-sp2">'+
                    '<figure>' +
        '<a href="' + product.url + '" class="center-block"><img class="lazyload" data-src="' + product.thumbnail + '" src="' + product.thumbnail + '" alt="' + product.title + '"></a>' +
                    '<figcaption>' +
                    '<h3><a href="' + product.url + '">' + product.title + '</a></h3>' +
                    '<div class="brief">' + product.description + '</div>' +
                    '</figcaption>'+
                    '</figure>'+
                '</div>'+
        '</div>';
    return item;
}

function generatePagination(numPage) {
    var pagination = '';
    for (var i = 0; i < numPage; i++) {
        if (i === 0) {
            pagination += '<li data-id="' + i + '" class="active"><span>' + (i + 1) + '</span></li>';
        } else {
            pagination += '<li data-id="' + i + '"><a href="#">'+(i+1)+'</a></li>';
        }
    }
    $('#pagination').html(pagination);
    initialPaginationClick();
}

function initialPaginationClick() {
    $('#pagination li').click(function () {
        $('#pagination li').removeClass('active');
        $('#pagination li').each(function (e, i) {
            $(this).html('<a href="#">' + $(this).text() + '</a>');
        });
        $(this).addClass('active');
        $(this).html('<span>' + $(this).text() + '</span>');
        getListProduct($(this).attr('data-id'));
    });
}