(function () {
    getListRandomPromotionNews();
})();

function getListRandomPromotionNews() {
    requestAjaxGet('/api/ApiAbout/getrandomlistpromotionnews').done(function (data) {
        $('#lst-random-news').after(generateListRandomPromotionNews(data));
    }).fail();
}

function generateListRandomPromotionNews(news) {
    var lstNews = '';
    for (var i = 0; i < news.length; i++) {
        lstNews += '<div class="item-newsOther">' +
            '<time>' + news[i].publishedDate+'</time>' +
            '<h4><a href="' + news[i].url +'">'+news[i].title+'</a></h4>' +
            '</div>';
    }
    return lstNews;
}