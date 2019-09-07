function jtExportToExcel() {
    $("#kq-tinhdunobandau").table2excel({
        name: "Ty gia VietBank",
        filename: "VietBank.com.vn",
        fileext: ".xls",
        exclude_img: true,
        exclude_links: true,
        exclude_inputs: true
    });
}
function jtprinttygia() {
    var pageTitle = 'Ty gia VietBank';
    stylesheet = '/Content/user/css/addons.css';
    stylesheet1 = '/Content/user/css/main.css';
    win = window.open('', 'Print', 'width=500,height=300');
    win.document.write('<html><head><title>' + pageTitle + '</title>' +
        '<link rel="stylesheet" href="' + stylesheet + '">' +
        '<link rel="stylesheet" href="' + stylesheet1 + '">' +
        '</head><body class="hotro"><div class="block-exchangeRate">' + $('#kq-tinhdunobandau')[0].outerHTML + '</div>' +
        '<script src=\"/Content/user/js/jquery.3.1.1.min.js\"><\/script>' +
        '<script type="text/javascript">' +
        'jQuery(document).ready(function ($) {' +
        'window.print();' +
        'window.close();' +
        '})' +
        '<\/script></body></html>');
    win.document.close();
    //win.print();
    //win.close();
    return false;
}
jQuery(document).ready(function ($) {
    $('#btn-tinhnogiamdan').click(function (event) {
        /* Act on the event */
        tinhnogiamdan();
    });
    $('#submit-uoctinhkhoangvai').click(function (event) {
        /* Act on the event */
        uoctinhkhoangvay();
    });

    $('.button-radio').click(function (event) {
        //alert('#' + $(this).attr('data-id') + '');
        $('.table-radio').addClass('hidden');
        $('#' + $(this).attr('data-id') + '').removeClass('hidden');
    });

    /*Active left menu*/
    var pathname = window.location.pathname;
    $('ul.left-menusp a').each(function (i) {
        var href = $(this).attr('href');
        if (href.indexOf(pathname) !== -1) {
            $('ul.left-menusp li.active').removeClass('active');
            $(this).parent().addClass('active');
            $(this).parent().parent().attr("style", "display:block");
            $(this).parent().parent().parent().addClass('active');
        }
    });

});
function formatTypeCurrency(num) {
    var str = num.toString(), parts = false, output = [], i = 1, formatted = null;
    if (str.indexOf(".") > 0) {
        parts = str.split(".");
        str = parts[0];
    }
    str = str.split("").reverse();
    for (var j = 0, len = str.length; j < len; j++) {
        if (str[j] !== ",") {
            output.push(str[j]);
            if (i % 3 === 0 && j < (len - 1)) {
                output.push(",");
            }
            i++;
        }
    }
    formatted = output.reverse().join("");
    return (formatted + ((parts) ? "." + parts[1].substr(0, 2) : ""));
};
function escapeRegExp(str) {
    return str.replace(/([.*+?^=!:${}()|\[\]\/\\])/g, "\\$1");
}
function replaceAll(str, find, replace) {
    return str.replace(new RegExp(escapeRegExp(find), 'g'), replace);
}
function uoctinhkhoangvay() {
    var sotien = replaceAll($('#so-tien-tra-moi-thang').val(), ',', '');
    var sothang = $('#so-thang-vay').val();
    var laisuat = $('#lai-suat-vay').val();
    var ketqua = (sotien * sothang * 12) / (12 + (laisuat / 100) * sothang);

    $('#du-dinh-tra-no').text((Math.round(sotien)).toString().replace(/\B(?=(\d{3})+(?!\d))/g, ","));
    $('#so-tien-vay-toi-da').text((Math.round(ketqua)).toString().replace(/\B(?=(\d{3})+(?!\d))/g, ","));
}
function tinhnogiamdan() {
    // body...
    var html = '<tr><th>Kỳ trả nợ</th><th>Nợ gốc còn lại</th><th>Gốc phải trả</th><th>Lãi phải trả</th><th>Tổng phải trả</th></tr>';
    var gocvay = replaceAll($('#sotienvay').val(), ',', '');
    var laisuat = $('#laisuat').val();
    var thoigian = $('#thoigianvay').val();
    var noconlai = 0;
    var goctrahangthang = gocvay / thoigian;
    var laiphaitra = 0;
    var tongsotientrahangthang = 0;
    var sum_noconlai = 0;
    var sum_goctrahangthang = 0;
    var sum_laiphaitra = 0;
    var sum_tongsotientrahangthang = 0;
    for (var i = 1; i <= thoigian; i++) {
        if (i === 1) {
            noconlai = gocvay;
            laiphaitra = noconlai * (laisuat / 100) / 12;
            tongsotientrahangthang = goctrahangthang + laiphaitra;
        } else {
            noconlai = noconlai - goctrahangthang;
            laiphaitra = noconlai * (laisuat / 100) / 12;
            tongsotientrahangthang = goctrahangthang + laiphaitra;
        }
        sum_noconlai = sum_noconlai + noconlai;
        sum_goctrahangthang = sum_goctrahangthang + goctrahangthang;
        sum_laiphaitra = sum_laiphaitra + laiphaitra;
        sum_tongsotientrahangthang = sum_tongsotientrahangthang + tongsotientrahangthang;
        html = html + '<tr>';
        html = html + '<td>' + i + '</td>';
        html = html + '<td>' + (Math.round(noconlai)).toString().replace(/\B(?=(\d{3})+(?!\d))/g, ",") + '</td>';
        html = html + '<td>' + (Math.round(goctrahangthang)).toString().replace(/\B(?=(\d{3})+(?!\d))/g, ",") + '</td>';
        html = html + '<td>' + (Math.round(laiphaitra)).toString().replace(/\B(?=(\d{3})+(?!\d))/g, ",") + '</td>';
        html = html + '<td>' + (Math.round(tongsotientrahangthang)).toString().replace(/\B(?=(\d{3})+(?!\d))/g, ",") + '</td>';
        html = html + '</tr>';
    }
    html = html + '<tr>';
    html = html + '<td colspan="2">Tổng cộng</td>';
    html = html + '<td>' + Math.round(sum_goctrahangthang).toString().replace(/\B(?=(\d{3})+(?!\d))/g, ",") + '</td>';
    html = html + '<td>' + Math.round(sum_laiphaitra).toString().replace(/\B(?=(\d{3})+(?!\d))/g, ",") + '</td>';
    html = html + '<td>' + Math.round(sum_tongsotientrahangthang).toString().replace(/\B(?=(\d{3})+(?!\d))/g, ",") + '</td>';
    html = html + '</tr>';
    $('#kq-tinhdunobandau').html(html);
}
function tienlanhlaituan(sotien, sotuan, laisuat) {
    var tienlaidinhky = (sotien * (laisuat / 100) * 7) / 360;
    var tongtientienlai = (sotien * (laisuat / 100) * (sotuan * 7)) / 360;
    var tongsotiennhanduoc = Math.round(sotien) + Math.round(tongtientienlai);
    $('.tien-lai-dinh-ky').text((Math.round(tienlaidinhky)).toString().replace(/\B(?=(\d{3})+(?!\d))/g, ","));
    $('.tong-tien-lai').text((Math.round(tongtientienlai)).toString().replace(/\B(?=(\d{3})+(?!\d))/g, ","));
    $('.tong-so-tien-nhan-duoc').text((Math.round(tongsotiennhanduoc)).toString().replace(/\B(?=(\d{3})+(?!\d))/g, ","));
}
function tienlanhlaithang(sotien, sothang, laisuat) {
    var tienlaidinhky = (sotien * (laisuat / 100) * 30) / 360;
    var tongtientienlai = (sotien * (laisuat / 100) * (sothang * 30)) / 360;
    var tongsotiennhanduoc = Math.round(sotien) + Math.round(tongtientienlai);
    $('.tien-lai-dinh-ky').text((Math.round(tienlaidinhky)).toString().replace(/\B(?=(\d{3})+(?!\d))/g, ","));
    $('.tong-tien-lai').text((Math.round(tongtientienlai)).toString().replace(/\B(?=(\d{3})+(?!\d))/g, ","));
    $('.tong-so-tien-nhan-duoc').text((Math.round(tongsotiennhanduoc)).toString().replace(/\B(?=(\d{3})+(?!\d))/g, ","));
}
function tienlanhlainam(sotien, sonam, laisuat) {
    var tienlaidinhky = (sotien * (laisuat / 100) * 360) / 360;
    var tongtientienlai = (sotien * (laisuat / 100) * (sonam * 360)) / 360;
    var tongsotiennhanduoc = Math.round(sotien) + Math.round(tongtientienlai);
    $('.tien-lai-dinh-ky').text((Math.round(tienlaidinhky)).toString().replace(/\B(?=(\d{3})+(?!\d))/g, ","));
    $('.tong-tien-lai').text((Math.round(tongtientienlai)).toString().replace(/\B(?=(\d{3})+(?!\d))/g, ","));
    $('.tong-so-tien-nhan-duoc').text((Math.round(tongsotiennhanduoc)).toString().replace(/\B(?=(\d{3})+(?!\d))/g, ","));
}
function tienlanhlaiquy(sotien, sothang, laisuat) {
    var tienlaidinhky = (sotien * (laisuat / 100) * 30) / 360;
    var tongtientienlai = (sotien * (laisuat / 100) * (sonam * 30)) / 360;
    var tongsotiennhanduoc = Math.round(sotien) + Math.round(tongtientienlai);
    $('.tien-lai-dinh-ky').text((Math.round(tienlaidinhky)).toString().replace(/\B(?=(\d{3})+(?!\d))/g, ","));
    $('.tong-tien-lai').text((Math.round(tongtientienlai)).toString().replace(/\B(?=(\d{3})+(?!\d))/g, ","));
    $('.tong-so-tien-nhan-duoc').text((Math.round(tongsotiennhanduoc)).toString().replace(/\B(?=(\d{3})+(?!\d))/g, ","));
}
/*Theo cuoi ky*/
function tienlanhlaituan_cuoiky(sotien, sotuan, laisuat) {
    var tienlaidinhky = (sotien * (laisuat / 100) * (sotuan * 7)) / 360;
    var tongtientienlai = (sotien * (laisuat / 100) * (sotuan * 7)) / 360;
    var tongsotiennhanduoc = Math.round(sotien) + Math.round(tongtientienlai);
    $('.tien-lai-dinh-ky').text((Math.round(tienlaidinhky)).toString().replace(/\B(?=(\d{3})+(?!\d))/g, ","));
    $('.tong-tien-lai').text((Math.round(tongtientienlai)).toString().replace(/\B(?=(\d{3})+(?!\d))/g, ","));
    $('.tong-so-tien-nhan-duoc').text((Math.round(tongsotiennhanduoc)).toString().replace(/\B(?=(\d{3})+(?!\d))/g, ","));
}
function tienlanhlaithang_cuoiky(sotien, sothang, laisuat) {
    var tienlaidinhky = (sotien * (laisuat / 100) * (sothang * 30)) / 360;
    var tongtientienlai = (sotien * (laisuat / 100) * (sothang * 30)) / 360;
    var tongsotiennhanduoc = Math.round(sotien) + Math.round(tongtientienlai);
    $('.tien-lai-dinh-ky').text((Math.round(tienlaidinhky)).toString().replace(/\B(?=(\d{3})+(?!\d))/g, ","));
    $('.tong-tien-lai').text((Math.round(tongtientienlai)).toString().replace(/\B(?=(\d{3})+(?!\d))/g, ","));
    $('.tong-so-tien-nhan-duoc').text((Math.round(tongsotiennhanduoc)).toString().replace(/\B(?=(\d{3})+(?!\d))/g, ","));
}
function tienlanhlainam_cuoiky(sotien, sonam, laisuat) {
    var tienlaidinhky = (sotien * (laisuat / 100) * (sonam * 360)) / 360;
    var tongtientienlai = (sotien * (laisuat / 100) * (sonam * 360)) / 360;
    var tongsotiennhanduoc = Math.round(sotien) + Math.round(tongtientienlai);
    $('.tien-lai-dinh-ky').text((Math.round(tienlaidinhky)).toString().replace(/\B(?=(\d{3})+(?!\d))/g, ","));
    $('.tong-tien-lai').text((Math.round(tongtientienlai)).toString().replace(/\B(?=(\d{3})+(?!\d))/g, ","));
    $('.tong-so-tien-nhan-duoc').text((Math.round(tongsotiennhanduoc)).toString().replace(/\B(?=(\d{3})+(?!\d))/g, ","));
}
function tienlanhlaiquy_cuoiky(sotien, sothang, laisuat) {
    var tienlaidinhky = (sotien * (laisuat / 100) * (sonam * 30)) / 360;
    var tongtientienlai = (sotien * (laisuat / 100) * (sonam * 30)) / 360;
    var tongsotiennhanduoc = Math.round(sotien) + Math.round(tongtientienlai);
    $('.tien-lai-dinh-ky').text((Math.round(tienlaidinhky)).toString().replace(/\B(?=(\d{3})+(?!\d))/g, ","));
    $('.tong-tien-lai').text((Math.round(tongtientienlai)).toString().replace(/\B(?=(\d{3})+(?!\d))/g, ","));
    $('.tong-so-tien-nhan-duoc').text((Math.round(tongsotiennhanduoc)).toString().replace(/\B(?=(\d{3})+(?!\d))/g, ","));
}
/*End cuoi ky*/
function tienlanhlaicuoiky(sotien, sonam, laisuat) {
    var tienlaidinhky = (sotien * (laisuat / 100) * 90) / 360;
    var tongtientienlai = (sotien * (laisuat / 100) * (sonam * 90)) / 360;
    var tongsotiennhanduoc = Math.round(sotien) + Math.round(tongtientienlai);
    $('.tien-lai-dinh-ky').text((Math.round(tienlaidinhky)).toString().replace(/\B(?=(\d{3})+(?!\d))/g, ","));
    $('.tong-tien-lai').text((Math.round(tongtientienlai)).toString().replace(/\B(?=(\d{3})+(?!\d))/g, ","));
    $('.tong-so-tien-nhan-duoc').text((Math.round(tongsotiennhanduoc)).toString().replace(/\B(?=(\d{3})+(?!\d))/g, ","));
}
jQuery(document).ready(function ($) {
    /**Tinh lanh lai person**/
    $('#ky-lanh-lai-person').change(function () {
        /* Act on the event */
        $('#ky-hang-gui-person input').removeAttr("disabled");
        $('#ky-hang-gui-person span').text($(this).val());
    });
    $('#uoc-tinh-person').click(function () {
        if ($('#so-tien-goi-person').val() != null && $('#ky-hang-gui-person input').val() != null && $('#lai-suat-person').val() != null) {

            switch ($('#ky-lanh-lai-person').val()) {
                case 'tuần':
                    tienlanhlaituan(replaceAll($('#so-tien-goi-person').val(), ',', ''), $('#ky-hang-gui-person input').val(), $('#lai-suat-person').val());
                    break;
                case 'tháng':
                    tienlanhlaithang(replaceAll($('#so-tien-goi-person').val(), ',', ''), $('#ky-hang-gui-person input').val(), $('#lai-suat-person').val());
                    break;
                case 'quý':
                    tienlanhlaiquy(replaceAll($('#so-tien-goi-person').val(), ',', ''), $('#ky-hang-gui-person input').val(), $('#lai-suat-person').val());
                    break;
                default:
                    tienlanhlainam(replaceAll($('#so-tien-goi-person').val(), ',', ''), $('#ky-hang-gui-person input').val(), $('#lai-suat-person').val());
                    break;
            }


        }
    });
    /**End tinh lanh lai person**/
    $("#so-tien-tra-moi-thang").keyup(function (e) {
        $(this).val(formatTypeCurrency($(this).val()));
    });
    $("#sotienvay").keyup(function (e) {
        $(this).val(formatTypeCurrency($(this).val()));
    });
    $("#so-tien-goi-person").keyup(function (e) {
        $(this).val(formatTypeCurrency($(this).val()));
    });
    $("#so-tien-goi-enterprise").keyup(function (e) {
        $(this).val(formatTypeCurrency($(this).val()));
    });
    /**Tinh lanh lai enterprise**/
    $('#ky-lanh-lai-enterprise').change(function () {
        /* Act on the event */
        $('#ky-hang-gui-enterprise input').removeAttr("disabled");
        $('#ky-hang-gui-enterprise span').text($(this).val());
    });
    $('#uoc-tinh-enterprise').click(function () {
        if ($('#so-tien-goi-enterprise').val() != null && $('#ky-hang-gui-enterprise input').val() != null && $('#lai-suat-enterprise').val() != null) {
            if (parseInt($('#cach-tinh-enterprise').val()) === 0) {
                switch ($('#ky-lanh-lai-enterprise').val()) {
                    case 'tuần':
                        tienlanhlaituan(replaceAll($('#so-tien-goi-enterprise').val(), ',', ''), $('#ky-hang-gui-enterprise input').val(), $('#lai-suat-enterprise').val());
                        break;
                    case 'tháng':
                        tienlanhlaithang(replaceAll($('#so-tien-goi-enterprise').val(), ',', ''), $('#ky-hang-gui-enterprise input').val(), $('#lai-suat-enterprise').val());
                        break;
                    case 'quý':
                        tienlanhlaiquy(replaceAll($('#so-tien-goi-enterprise').val(), ',', ''), $('#ky-hang-gui-enterprise input').val(), $('#lai-suat-enterprise').val());
                        break;
                    default:
                        tienlanhlainam(replaceAll($('#so-tien-goi-enterprise').val(), ',', ''), $('#ky-hang-gui-enterprise input').val(), $('#lai-suat-enterprise').val());
                        break;
                }
            } else {
                switch ($('#ky-lanh-lai-enterprise').val()) {
                    case 'tuần':
                        tienlanhlaituan_cuoiky(replaceAll($('#so-tien-goi-enterprise').val(), ',', ''), $('#ky-hang-gui-enterprise input').val(), $('#lai-suat-enterprise').val());
                        break;
                    case 'tháng':
                        tienlanhlaithang_cuoiky(replaceAll($('#so-tien-goi-enterprise').val(), ',', ''), $('#ky-hang-gui-enterprise input').val(), $('#lai-suat-enterprise').val());
                        break;
                    case 'quý':
                        tienlanhlaiquy_cuoiky(replaceAll($('#so-tien-goi-enterprise').val(), ',', ''), $('#ky-hang-gui-enterprise input').val(), $('#lai-suat-enterprise').val());
                        break;
                    default:
                        tienlanhlainam_cuoiky(replaceAll($('#so-tien-goi-enterprise').val(), ',', ''), $('#ky-hang-gui-enterprise input').val(), $('#lai-suat-enterprise').val());
                        break;
                }
            }
        }
    });
    /**End tinh lanh lai enterprise**/
});