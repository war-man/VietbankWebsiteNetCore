function jtprinttygia() {
    var pageTitle = 'Ty gia VietBank';
    stylesheet = '/Content/user/css/addons.css';
    stylesheet1 = '/Content/user/css/main.css';
    win = window.open('', 'Print', 'width=500,height=300');
    win.document.write('<html><head><title>' + pageTitle + '</title>' +
        '<link rel="stylesheet" href="' + stylesheet + '">' +
        '<link rel="stylesheet" href="' + stylesheet1 + '">' +
        '</head><body class="hotro"><div class="block-exchangeRate">' + $('#frmtbltygia')[0].outerHTML + '</div>' +
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
function jtExportToExcel() {
    $("#tbltygia").table2excel({
        name: "Ty gia VietBank",
        filename: "VietBank.com.vn",
        fileext: ".xls",
        exclude_img: true,
        exclude_links: true,
        exclude_inputs: true
    });
}
function getDataToViewChart() {
    var tungay = moment($("#fromdate").datepicker("getDate")).format("DD/MM/YYYY");
    var denngay = moment($("#todate").datepicker("getDate")).format("DD/MM/YYYY");
    var ngoaite1 = $('#val-current1').val();
    var ngoaite2 = $('#val-current2').val();
    requestAjaxGet('/api/ApiSupport/getfiltercurrencychard?fromDate=' + tungay + '&toDate=' + denngay + '&currency1=' + ngoaite1 + '&currency2=' + ngoaite2)
        .done(function (result) {
            var datetime = [];
            var ArrCurrency1 = [];
            var ArrCurrency2 = [];
            for (var i = 0; i < result.length; i++) {
                if (datetime.indexOf(result[i].stringDate) === -1) {
                    datetime.push(result[i].stringDate);
                }
            }
            for (var i = 0; i < datetime.length; i++) {
                for (var j = 0; j < result.length; j++) {
                    if (result[j].stringDate === datetime[i] && result[j].currencyCode === ngoaite1) {
                        ArrCurrency1.push(result[j].avgCurrency);
                    }
                    if (result[j].stringDate === datetime[i] && result[j].currencyCode === ngoaite2) {
                        ArrCurrency2.push(result[j].avgCurrency);
                    }
                }
            }
            showChart(datetime, ArrCurrency1, ArrCurrency2, 'Ngoại tệ 1:' + ngoaite1, 'Ngoại tệ 2:' + ngoaite2);
        })
        .fail(function (error) {
            console.log(error);
        });
}
function showChart(mang, mang1, mang2, tennt1, tennt2) {

    //var mang = ['01/01/2017', '02/01/2017', '03/01/2017', '04/01/2017', '05/01/2017', '06/01/2017', '07/01/2017', '08/01/2017', '09/01/2017'];
    //var mang1 = [3.504E7, 3.517E7, 3.514E7, 3.51E7, 3.513E7, 3.5E7, 3.508E7, 3.512E7, 3.526E7];
    //var mang2=[21400.0,21360.0,21340.0,21330.0,21310.0,21310.0,21340.0,21330.0,21330.0];

    var chart = new Highcharts.Chart({
        chart: {
            renderTo: 'container',
            type: 'line',
            marginRight: 100,
            marginBottom: 70
        },
        title: {
            text: '',
            x: -20 //center
        },

        xAxis: {
            categories: mang,
            type: 'datetime',
            startOnTick: true,
            labels: {
                formatter: function () {
                    return this.value.toString();
                },
                rotation: -45,
                y: 35,
                align: 'center'
            }
        },

        yAxis: [{ // Primary yAxis
            labels: {
                formatter: function () {
                    return this.value;
                },
                style: {
                    color: '#4572A7'
                }
            },
            title: {
                text: '',
                style: {
                    color: '#4572A7'
                }
            }
        }, { // Secondary yAxis
            title: {
                text: '',
                style: {
                    color: '#33C148'
                }
            },

            labels: {
                formatter: function () {
                    //return this.value;
                    return Highcharts.numberFormat(this.value / 1000, 0) + "K";
                    //return this.value;
                },
                style: {
                    color: '#33C148'
                }
            },
            opposite: true
        }],
        tooltip: {
            formatter: function () {
                return '<b>Ngày ' +
                    this.x + ': ' + this.y + '</b>';
            }
        },

        legend: {
            layout: 'vertical',
            align: 'center',
            verticalAlign: 'top',
            x: 150,
            y: 10,
            borderWidth: 0
        },
        series: [{
            name: tennt1,
            color: '#33C148',
            type: 'line',
            yAxis: 1,
            data: mang1

        }, {
            name: tennt2,
            color: '#4572A7',
            type: 'line',
            data: mang2
        }]
    });

}

function generateCountTimeUpdate(time) {
    var countTime = '<option></option>';
    for (var i = 1; i <= time; i++) {
        countTime += '<option value="'+i+'">'+i+'</option>';
    }
    $('#count-update select').html(countTime);
}

function generateTableCurrency(currency) {
    var currencyTable = '';
    for (var i = 0; i < currency.length; i++) {
        currencyTable += '<tr>'+
            '<td><img class="lazyload" data-src="/img/lang/lang_' + currency[i].currencyCode +'.png" style="width:40px;" src="/img/lang/lang_' + currency[i].currencyCode+'.png">' + currency[i].currencyCode + '</td>'+
        '<td>' + currency[i].buyCash + '</td>'+
        '<td>' + currency[i].buyTransfer + '</td>'+
        '<td>' + currency[i].saleTransfer + '</td>'+
        '</tr>';
    }
    $('#content-currency').html(currencyTable);
}

jQuery(document).ready(function ($) {
    getLastDateUpdate();
    getCurrencyCurrent();
    getCountTimeCurrent();
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
    $('#fromdate').datepicker({
        format: 'dd/mm/yyyy',
        autoclose: true
    });
    $('#todate').datepicker({
        format: 'dd/mm/yyyy',
        autoclose: true
    });
    $('#datecurrent').datepicker({
        format: 'dd/mm/yyyy',
        autoclose: true
    }).on('changeDate', function (ev) {
        requestAjaxGet('/api/ApiSupport/getcountupdatecurrencywheredate?date=' + moment(ev.date).format("MM/DD/YYYY"))
            .done(function (data) {
                generateCountTimeUpdate(data)
            })
            .fail(function (error) {
                console.log(error);
            });
    });
    //showChart();


    $("#filter-currency").click(function (event) {
        /* Act on the event */
        var datetime = moment($("#datecurrent").datepicker("getDate")).format("MM/DD/YYYY");
        var counttime = $('#count-update select').val();
        requestAjaxGet('/api/ApiSupport/getfiltercurrency?date=' + datetime + '&counttime=' + counttime)
            .done(function (data) {
                generateTableCurrency(data);
            })
            .fail(function (error) {
                console.log(error);
            });
    });
});function getCurrencyCurrent() {
    requestAjaxGet('/api/ApiSupport/getcountupdatecurrencywheredate?date=' + moment(new Date()).format("MM/DD/YYYY"))
        .done(function (data) {
            $.get('/api/ApiSupport/getfiltercurrency?date=' + moment(new Date()).format("MM/DD/YYYY") + '&counttime=' + data, function (data) {
                generateTableCurrency(data);
            });
        })
        .fail(function (error) {
            console.log(error);
        });
}function getCountTimeCurrent() {
    $.get('/api/ApiSupport/getcountupdatecurrencywheredate?date=' + moment(new Date()).format("MM/DD/YYYY"), function (data) {
        /*optional stuff to do after success */
        generateCountTimeUpdate(data);
    });
}$(document).ready(function () {
    var href = window.location.href;
    if (href.indexOf("#chart") > 0) {
        $('#hotro-ct-2').removeClass('hidden');
    } else if (href.indexOf("#currency-converter") > 0) {
        $('#hotro-ct-3').removeClass('hidden');
    } else {
        $('#hotro-ct-1').removeClass('hidden');
    }

    $('.li-chart').click(function (event) {
        $('.hotro-ct').addClass('hidden');
        $('#hotro-ct-2').removeClass('hidden');
    });
    $('.li-currency-converter').click(function (event) {
        $('.hotro-ct').addClass('hidden');
        $('#hotro-ct-3').removeClass('hidden');
    });

    // THIS EVENT MAKES SURE THAT THE BACK/FORWARD BUTTONS WORK AS WELL
    window.onpopstate = function (event) {
        var href = window.location.href;
        if (href.indexOf("#chart") > 0) {
            $('#hotro-ct-2').removeClass('hidden');
        } else if (href.indexOf("#currency-converter") > 0) {
            $('#hotro-ct-3').removeClass('hidden');
        } else {
            $('#hotro-ct-1').removeClass('hidden');
        }
    };
});
$(document).ready(function () {
    $('#btn-convert').click(function (event) {

        requestAjaxGet('/api/ApiSupport/getcurrencyconvert?effCode=' + $('#val-effcode').val() + '&currency=' + $('#val-curreny').val())
            .done(function (result) {
                generateCurrencyConvert(result);
            })
            .fail(function (error) {
                console.log(error);
            });
    });
    $("#val-curreny").keyup(function (e) {
        $(this).val(formatTypeCurrency($(this).val()));
    });
});

function generateCurrencyConvert(currency) {
    var currencyConvert = '';
    for (var i = 0; i < currency.length; i++) {
        currencyConvert += '<div class="col-xs-12 col-sm-6 col-md-4"><div class="item-exm"><div style="padding-right: 10px;" class="flag"><img class="lazyload" data-src="/Content/user/image/lang/lang_' + currency[i].currencyCode + '.png" src="/Content/user/image/lang/lang_' + currency[i].currencyCode + '.png"></div><div class="ex-info"><div class="rate">' + currency[i].convertCurrency+ ' $</div><div class="unit">' + currency[i].currencyCode+'</div></div></div></div>';
    }
    $('.exchange-list .row').html(currencyConvert);
}

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

function getLastDateUpdate() {
    $.get('/api/ApiSupport/getlastdateupdate', function (data) {
        /*optional stuff to do after success */
        $('#last-date-update').text(data);
    });
}