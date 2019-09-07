(function () {
    initialBtnVerify();
})();

function initialBtnVerify() {
    $('#btn-verify').click(function () {
        var acctNbr = $('#GuaranteeAcct').val();
        var seriesNo = $('#GuaranteeCode').val();
        getGuarantee(acctNbr, seriesNo);
    });
}

function getGuarantee(acctNbr, seriesNo) {
    $.get('/api/ApiSupport/getguaranteeletter?acctNbr=' + acctNbr + '&seriesNo=' + seriesNo, function (data) {
        $('#infoGuarantee').html(data);
    });
}