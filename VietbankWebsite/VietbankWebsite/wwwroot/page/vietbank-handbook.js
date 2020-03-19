(function () {
    getListVietbankNews();
})();

function getListVietbankNews() {
    requestAjaxGet('/api/ApiAbout/getlistvietbankhandbook/0/9').done(function (data) {
        $('#lst-vietbank-handbook').html(loopNews(data.listNewsItems));
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
    var item = '<div class="col-xs-12 col-md-6 col-lg-4 item-newsWrap"><div class="item-news"><figure><a href="' + news.url + '"><img class="lazyload" data-src="' + news.thumbnail + '" src="' + news.thumbnail + '" alt="Tin tuc"></a><figcaption><div class="title-news clearfix"><h4>' + news.categoryName + '</h4><time>' + moment(news.publishDate).format("DD/MM/YYYY") + '</time></div><h3><a href="' + news.url + '">' + news.title.replace(/<[^>]*>?/gm, '').substring(0, 60).concat('...') + '</a></h3><div class="brief">' + replaceHtmlToNull(news.description,190) + '</div></figcaption></figure></div></div>';
    return item;
}