(function () {
    getListVietbankNews();
})();

function getListVietbankNews() {
    requestAjaxGet('/api/ApiAbout/getlistpromotionnews/0/9').done(function (data) {
        $('#lst-promotion-news').html(loopNews(data.listNewsItems));
        generatePagination(data.pageSize);
    }).fail();
}

function getListVietbankNewsWithPagination(pageCurrent) {
    requestAjaxGet('/api/ApiAbout/getlistpromotionnews/' + pageCurrent + '/9').done(function (data) {
        $('#lst-promotion-news').html(loopNews(data.listNewsItems));
    }).fail();
}

function loopNews(data) {
    var lstItem = '';
    for (var i = 0; i < data.length; i++) {
        lstItem += generateNewsItem(data[i]);
    }
    return lstItem;
}

function generateNewsItem(news) {
    var item = '<div class="col-xs-12 col-md-6 col-lg-4 item-newsWrap"><div class="item-news"><figure><a href="' + news.url + '"><img src="' + news.thumbnail + '" alt="Tin tuc"></a><figcaption><div class="title-news clearfix"><h4>' + news.categoryName + '</h4><time>' + moment(news.publishDate).format("DD/MM/YYYY") + '</time></div><h3><a href="' + news.url + '">' + news.title.replace(/<[^>]*>?/gm, '').substring(0, 60).concat('...') + '</a></h3><div class="brief">' + replaceHtmlToNull(news.description,190) + '</div></figcaption></figure></div></div>';
    return item;
}

function generatePagination(numpage) {
    if (numpage > 0) {
        var pagination = '';
        for (var i = 0; i < numpage; i++) {
            if (i == 0) {
                pagination += '<li data-page-current="' + i + '" class="active"><a href="#!">' + (i + 1) + '</a></li>';
            } else {
                pagination += '<li data-page-current="' + i + '"><a href="#!">' + (i + 1) + '</a></li>';
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
        getListVietbankNewsWithPagination($(this).attr('data-page-current'));
    });
}