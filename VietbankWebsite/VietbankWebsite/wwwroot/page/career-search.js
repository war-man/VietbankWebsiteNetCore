(function () {
    initialBtnSearchClick();
})();

function initialBtnSearchClick() {
    $('#search-career').click(function () {
        var address = $('select[name=address]').val();
        var career = $('select[name=career]').val();
        var keyword = $('input[name=keyword]').val();
        requestSearchCareer(keyword, address, career);
    });
}

function requestSearchCareer(keyword, address, career) {
    requestAjaxGet('/api/ApiCareer/searchcareer?key=' + keyword + '&city=' + address + '&major=' + career).done(function (data) {
        generateListCareer(data);
    }).fail(function (error) {
        console.error;
    });
}

function generateListCareer(career) {
    var lstCareer = '';
    for (var i = 0; i < career.length; i++) {
        lstCareer += '<div class="jobs-item">'+
                    '<div class="job_head">' +
                    '<div class="job-title"><a href="' + career[i].url + '">' + career[i].jobTitle + '</a></div>' +
                    '<div class="job-place">' + career[i].jobCity + '</div>' +
                    '<div class="job-date">' + career[i].createdDate + '<span class="status new">Mới</span></div>' +
                '</div>'+
            '</div>';
    }
    $('#list-career').html(lstCareer);
}