(function () {
    getProvince();
})();

function getProvince() {
    requestAjaxGet('/api/ApiBranch/getprovince').done(function (data) {
        generateSelectProvince(data)
    }).fail(function (error) {
        console.log(error);
    });
}

function generateSelectProvince(province) {
    var option = '<option></option>';
    for (var i = 0; i < province.length; i++) {
        option += '<option value="' + province[i].provinceId + '">' + province[i].name + '</option>';
    }
    $('select[id=tinh]').html(option);
    $('select[id=tinh]').select2({
        placeholder: 'Chọn tỉnh thành',
        width: '100%',
        height: '40px',
        containerCssClass: ':all:'
    });
    initSelectProvinceChange();
}

function initSelectProvinceChange() {
    $('select[id=tinh]').change(function () {
        $('input[name=Tinh]').val($(this)[0].options[$(this)[0].selectedIndex].text);
        getDistrict($(this).val());
    });
}

function getDistrict(province) {
    requestAjaxGet('/api/ApiBranch/getdistrict/' + province).done(function (data) {
        generateSelectDistrict(data);
    }).fail(function (error) {
        console.log(error);
    });
}

function generateSelectDistrict(district) {
    var option = '<option></option>';
    for (var i = 0; i < district.length; i++) {
        option += '<option value="' + district[i].districtId + '">' + district[i].name + '</option>';
    }
    $('select[name=district]').html(option);
    $('select[name=district]').select2({
        placeholder: 'Chọn quận/huyện',
        width: '100%',
        height: '40px',
        containerCssClass: ':all:'
    });
    initialSelectDistrictChange();
}

function initialSelectDistrictChange() {
    $('select[name=district]').change(function () {
        var province = $('select[id=tinh]').val();
        var district = $('select[name=district]').val();
        filterTransagencyMap(province, district);
    });
}

function filterTransagencyMap(province, district) {
    requestAjaxGet('/api/ApiBranch/filtertransagencymap/' + province + '/' + district).done(function (data) {
        generateSelectBranch(data);
    }).fail(function (error) {
    });
}

function generateSelectBranch(branch) {
    var option = '<option></option>';
    for (var i = 0; i < branch.length; i++) {
        option += '<option value="' + branch[i].branchCode + '">' + branch[i].transAgencyName + '</option>';
    }
    $('select[name=BranchId]').html(option);
    $('select[name=BranchId]').select2({
        placeholder: 'Chọn chi nhánh để nhận thẻ',
        width: '100%',
        height: '40px',
        containerCssClass: ':all:'
    });
}
