/// <reference path="jquery.d.ts" />
/// <reference path="google_chart.d.ts" />
google.charts.load('current', {
    'packages': ['corechart']
});
$(document).ready(function () {
    google.charts.setOnLoadCallback(main);
});
function getZ() {
    var R, z;
    R = Math.random();
    if (R < 0.5)
        z = R;
    else
        z = 1.5 - Math.sqrt(2 * (1 - R));
    return z;
}
function compareNumeric(a, b) {
    if (a > b)
        return 1;
    if (a < b)
        return -1;
}
function fun_1(amount, arr_z, m, chart_div, p, num) {
    for (var i = 0; i < amount; i++)
        arr_z[i] = getZ();
    arr_z.sort(compareNumeric);
    // var z_min = get_z_min(arr_z, amount);
    // var z_max = get_z_max(arr_z, amount);
    var z_min = arr_z[0];
    var z_max = arr_z[amount - 1];
    var sr = (z_max - z_min) / m;
    var arr_table = [];
    for (var i = 0; i < 5; i++) {
        arr_table[i] = [];
        for (var j = 0; j < m; j++) {
            arr_table[i][j] = 0;
        }
    }
    var X = sr;
    for (var i = 0, k = 0; i < amount;) {
        arr_table[1][k] = arr_z[i];
        X = z_min + ((k + 1) * sr);
        while (arr_z[i] <= X && i < amount) {
            arr_table[3][k]++;
            arr_table[0][k] = arr_z[i];
            i++;
        }
        k++;
    }
    // for (var i = 0; i < amount; i++)
    //     for (var k = 0; k < m; k++)
    //         if (arr_z[i] >= (z_min + k * sr) && arr_z[i] <= (z_min + (k + 1) * sr)) {
    //             if (arr_z[i] < arr_table[0][k])
    //                 arr_table[0][k] = arr_z[i];
    //             else
    //                 if (arr_z[i] > arr_table[1][k])
    //                     arr_table[1][k] = arr_z[i];
    //             arr_table[3][k]++;
    //             break;
    //         }
    for (var k = 0; k < m; k++) {
        arr_table[2][k] = (arr_table[0][k] + arr_table[1][k]) / 2;
        arr_table[4][k] = arr_table[3][k] / amount;
    }
    // вывод графика
    var data = new google.visualization.DataTable();
    data.addColumn('number', 'частота разряда');
    data.addColumn('number', 'иксы');
    var options = {
        title: 'График значений',
        hAxis: {
            title: 'иксы'
        },
        vAxis: {
            title: 'частота разряда',
            minValue: 0
        },
        explorer: { actions: ["dragToZoom", "rightClickToReset"], maxZoomIn: 1, maxZoomOut: 1 }
    };
    for (var i = 0; i < m; i++)
        data.addRows([
            [arr_table[2][i], arr_table[4][i]]
        ]);
    var chart = new google.visualization.ColumnChart(document.getElementById(chart_div));
    chart.draw(data, options);
    var p_j = 0, hi = 0;
    for (var i = 0; i < m; i++) {
        if (arr_table[0][i] > 0.5) {
            p_j = (1.5 * arr_table[0][i] - (Math.pow(arr_table[0][i], 2) / 2) - 0.125) - (1.5 * arr_table[1][i] - (Math.pow(arr_table[1][i], 2) / 2) - 0.125);
        }
        else {
            p_j = arr_table[0][i] - arr_table[1][i];
        }
        hi += ((arr_table[4][i] - p_j) * (arr_table[4][i] - p_j)) / p_j;
    }
    hi *= amount;
    // if (!isFinite(hi) || hi < 0) {
    //     var R = Math.random();
    //     hi = p - R;
    // }
    console.log(hi);
    if (hi < p)
        console.log(num + " выборка удовлетворяет условию");
    else
        console.log(num + " выборка не удовлетворяет условию");
}
function main() {
    var arr_z_50 = [], arr_z_100 = [], arr_z_1000 = [], arr_z_100000 = [], p_1 = 4.6, p_2 = 9.2, p_3 = 39.1;
    // fun_1(50, arr_z_50, 3, 'chart_div_1', p_1, 'первая');
    // fun_1(100, arr_z_100, 6, 'chart_div_2', p_2, 'вторая');
    for (var i = 0; i < 100; i++)
        fun_1(1000, arr_z_1000, 30, 'chart_div_3', p_3, 'третья');
    // fun_1(100000, arr_z_100000, 30, 'chart_div_4', p_3, 'червёртая');
}
function get_z_min(arr, n) {
    var z_min = arr[0];
    for (var i = 0; i < n; i++)
        if (arr[i] < z_min)
            z_min = arr[i];
    return z_min;
}
function get_z_max(arr, n) {
    var z_max = arr[0];
    for (var i = 0; i < n; i++)
        if (arr[i] > z_max)
            z_max = arr[i];
    return z_max;
}
