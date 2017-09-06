/// <reference path="jquery.d.ts" />
/// <reference path="google_chart.d.ts" />
google.charts.load('current', {
    'packages': ['corechart']
});

$(document).ready(function() {
    google.charts.setOnLoadCallback(main);
});

function getZ() {
    var R, z;

    R = Math.random();
    if (R > 0.5)
        z = (5 - Math.sqrt(25 - 10 * R)) / 2;
    else
        z = 1.5 - Math.sqrt(1 - 2 * R);

    return z;
}
function main() {
    var arr_z_50 = [], arr_z_100 = [], arr_z_1000 = [], arr_z_100000 = [];

    for (var i = 0; i < 50; i++)
        arr_z_50[i] = getZ();

    var z_min_50 = get_z_min(arr_z_50, 50);
    var z_max_50 = get_z_max(arr_z_50, 50);
    var m = 3;

    var sr = (z_max_50 - z_min_50) / m;

    var arr_table_50 = [];
    for (var i = 0; i < 5; i++) {
        arr_table_50[i] = [];
        for (var j = 0; j < m; j++) {
            if (i === 0)
                arr_table_50[i][j] = z_max_50;
            else if (i === 1)
                arr_table_50[i][j] = z_min_50;
            else
                arr_table_50[i][j] = 0;
        }
    }
    for (var i = 0; i < 50; i++) {
        for (var k = 0; k < m; k++) {
            if (arr_z_50[i] >= (z_min_50 + k * sr) && arr_z_50[i] <= (z_min_50 + (k + 1) * sr)) {
                if (arr_z_50[i] < arr_table_50[0][k])
                    arr_table_50[0][k] = arr_z_50[i];
                if (arr_z_50[i] > arr_table_50[1][k])
                    arr_table_50[1][k] = arr_z_50[i];
                arr_table_50[3][k]++;
                break;
            }
        }
    }

    for (var k = 0; k < m; k++) {
        arr_table_50[2][k] = (arr_table_50[0][k] + arr_table_50[1][k]) / 2;
        arr_table_50[4][k] = arr_table_50[3][k] / 50;
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
            [arr_table_50[2][i], arr_table_50[4][i]]
        ]);
    var chart = new google.visualization.ColumnChart(document.getElementById('chart_div_1'));
    chart.draw(data, options);

    var p_j = 0, hi = 0;
    for (var i = 0; i < m - 1; i++) {
        if(arr_table_50[0][i] > 0.5)
            p_j = (5 - Math.sqrt(25 - 10 * arr_table_50[1][i])) / 2 - (5 - Math.sqrt(25 - 10 * arr_table_50[0][i])) / 2;
        else
            p_j = arr_table_50[1][i] - arr_table_50[0][i];
        hi += Math.pow((arr_table_50[4][i] - p_j), 2) / p_j;
    }

    hi *= 50;
    var p_1 = 6.3, p_2 = 10.6, p_3 = 40.3;
    console.log(hi);
    if (hi > p_1)
        console.log("первая выборка удовлетворяет условию");
    else
        console.log("первая выборка не удовлетворяет условию");




    // 100



    for (var i = 0; i < 100; i++)
        arr_z_100[i] = getZ();

    var z_min_100 = get_z_min(arr_z_100, 100);
    var z_max_100 = get_z_max(arr_z_100, 100);
    m = 6;
    sr = (z_max_100 - z_min_100) / m;

    var arr_table_100 = [];
    for (var i = 0; i < 5; i++) {
        arr_table_100[i] = [];
        for (var j = 0; j < m; j++) {
            if (i === 0)
                arr_table_100[i][j] = z_max_100;
            else if (i === 1)
                arr_table_100[i][j] = z_min_100;
            else
                arr_table_100[i][j] = 0;
        }
    }
    for (var i = 0; i < 100; i++) {
        for (var k = 0; k < m; k++) {
            if (arr_z_100[i] >= (z_min_100 + k * sr) && arr_z_100[i] < (z_min_100 + (k + 1) * sr)) {
                if (arr_z_100[i] < arr_table_100[0][k])
                    arr_table_100[0][k] = arr_z_100[i];
                if (arr_z_100[i] > arr_table_100[1][k])
                    arr_table_100[1][k] = arr_z_100[i];
                arr_table_100[3][k]++;
                break;
            }
        }
    }

    for (var k = 0; k < m; k++) {
        arr_table_100[2][k] = (arr_table_100[0][k] + arr_table_100[1][k]) / 2;
        arr_table_100[4][k] = arr_table_100[3][k] / 100;
    }

    for (var i = 0; i < 5; i++)
        for (var j = 0; j < m; j++)
            // console.log(arr_table_100[i][j]);

            var data = new google.visualization.DataTable();
    data.addColumn('number', 'частота разряда');
    data.addColumn('number', 'иксы');
    // var options = {
    //     title: 'График значений',
    //     hAxis: {
    //         title: 'иксы'
    //     },
    //     vAxis: {
    //         title: 'частота разряда',
    //         minValue: 0
    //     },
    //     explorer: { actions: ["dragToZoom", "rightClickToReset"], maxZoomIn: .025, maxZoomOut: 10 }
    // };
    for (var i = 0; i < m; i++)
        data.addRows([
            [arr_table_100[2][i], arr_table_100[4][i]]
        ]);
    var chart = new google.visualization.ColumnChart(document.getElementById('chart_div_2'));
    chart.draw(data, options);


    var p_j = 0, hi = 0;
    for (var i = 0; i < m - 1; i++) {
        if(arr_table_100[0][i] > 0.5)
            p_j = (5 - Math.sqrt(25 - 10 * arr_table_100[1][i])) / 2 - (5 - Math.sqrt(25 - 10 * arr_table_100[0][i])) / 2;
        else
            p_j = arr_table_100[1][i] - arr_table_100[0][i];
        hi += Math.pow((arr_table_100[4][i] - p_j), 2) / p_j;
    }

    hi *= 100;
    var p_1 = 6.3, p_2 = 10.6, p_3 = 40.3;
    console.log(hi);


    if (hi > p_2)
        console.log("вторая выборка удовлетворяет условию");
    else
        console.log("вторая выборка не удовлетворяет условию");
    // 1000



    for (var i = 0; i < 1000; i++)
        arr_z_1000[i] = getZ();
    for (var i = 0; i < 1000; i++)
        arr_z_1000[i] = getZ();

    var z_min_1000 = get_z_min(arr_z_1000, 1000);
    var z_max_1000 = get_z_max(arr_z_1000, 1000);

    m = 30;
    sr = (z_max_1000 - z_min_1000) / m;

    var arr_table_1000 = [];
    for (var i = 0; i < 5; i++) {
        arr_table_1000[i] = [];
        for (var j = 0; j < m; j++) {
            if (i === 0)
                arr_table_1000[i][j] = z_max_1000;
            else if (i === 1)
                arr_table_1000[i][j] = z_min_1000;
            else
                arr_table_1000[i][j] = 0;
        }
    }
    for (var i = 0; i < 1000; i++) {
        for (var k = 0; k < m; k++) {
            if (arr_z_1000[i] >= (z_min_1000 + k * sr) && arr_z_1000[i] < (z_min_1000 + (k + 1) * sr)) {
                if (arr_z_1000[i] < arr_table_1000[0][k])
                    arr_table_1000[0][k] = arr_z_1000[i];
                if (arr_z_1000[i] > arr_table_1000[1][k])
                    arr_table_1000[1][k] = arr_z_1000[i];
                arr_table_1000[3][k]++;
                break;
            }
        }
    }

    for (var k = 0; k < m; k++) {
        arr_table_1000[2][k] = (arr_table_1000[0][k] + arr_table_1000[1][k]) / 2;
        arr_table_1000[4][k] = arr_table_1000[3][k] / 1000;
    }

    for (var i = 0; i < 5; i++)
        for (var j = 0; j < m; j++)
            var data = new google.visualization.DataTable();
    data.addColumn('number', 'частота разряда');
    data.addColumn('number', 'иксы');
    // var options = {
    //     title: 'График значений',
    //     hAxis: {
    //         title: 'иксы'
    //     },
    //     vAxis: {
    //         title: 'частота разряда',
    //         minValue: 0
    //     },
    //     explorer: { actions: ["dragToZoom", "rightClickToReset"], maxZoomIn: .025, maxZoomOut: 10 }
    // };
    for (var i = 0; i < m; i++)
        data.addRows([
            [arr_table_1000[2][i], arr_table_1000[4][i]]
        ]);
    var chart = new google.visualization.ColumnChart(document.getElementById('chart_div_3'));
    chart.draw(data, options);

    var p_j = 0, hi = 0;
    for (var i = 0; i < m - 1; i++) {
        if(arr_table_1000[0][i] > 0.5)
            p_j = (5 - Math.sqrt(25 - 10 * arr_table_1000[1][i])) / 2 - (5 - Math.sqrt(25 - 10 * arr_table_1000[0][i])) / 2;
        else
            p_j = arr_table_1000[1][i] - arr_table_1000[0][i];
        hi += Math.pow((arr_table_1000[4][i] - p_j), 2) / p_j;
    }
    hi *= 100;
    var p_1 = 6.3, p_2 = 10.6, p_3 = 40.3;
    console.log(hi);

    if (hi > p_3)
        console.log("третья выборка удовлетворяет условию");
    else
        console.log("третья выборка не удовлетворяет условию");


    // 100000



    for (var i = 0; i < 100000; i++)
        arr_z_100000[i] = getZ();

    var z_min_100000 = get_z_min(arr_z_100000, 100000);
    var z_max_100000 = get_z_max(arr_z_100000, 100000);

    m = 30;
    sr = (z_max_100000 - z_min_100000) / m;

    var arr_table_100000 = [];
    for (var i = 0; i < 5; i++) {
        arr_table_100000[i] = [];
        for (var j = 0; j < m; j++) {
            if (i === 0)
                arr_table_100000[i][j] = z_max_100000;
            else if (i === 1)
                arr_table_100000[i][j] = z_min_100000;
            else
                arr_table_100000[i][j] = 0;
        }
    }

    for (var i = 0; i < 100000; i++) {
        for (var k = 0; k < m; k++) {
            if (arr_z_100000[i] >= (z_min_100000 + k * sr) && arr_z_100000[i] < (z_min_100000 + (k + 1) * sr)) {
                if (arr_z_100000[i] < arr_table_100000[0][k])
                    arr_table_100000[0][k] = arr_z_100000[i];
                if (arr_z_100000[i] > arr_table_100000[1][k])
                    arr_table_100000[1][k] = arr_z_100000[i];
                arr_table_100000[3][k]++;
                break;
            }
        }
    }

    for (var k = 0; k < m; k++) {
        arr_table_100000[2][k] = (arr_table_100000[0][k] + arr_table_100000[1][k]) / 2;
        arr_table_100000[4][k] = arr_table_100000[3][k] / 100000;
    }

    for (var i = 0; i < 5; i++)
        for (var j = 0; j < m; j++)
            var data = new google.visualization.DataTable();
    data.addColumn('number', 'частота разряда');
    data.addColumn('number', 'иксы');
    // var options = {
    //     title: 'График значений',
    //     hAxis: {
    //         title: 'иксы'
    //     },
    //     vAxis: {
    //         title: 'частота разряда',
    //         minValue: 0
    //     },
    //     explorer: { actions: ["dragToZoom", "rightClickToReset"], maxZoomIn: .025, maxZoomOut: 10 }
    // };
    for (var i = 0; i < m; i++)
        data.addRows([
            [arr_table_100000[2][i], arr_table_100000[4][i]]
        ]);
    var chart = new google.visualization.ColumnChart(document.getElementById('chart_div_4'));
    chart.draw(data, options);

    var p_j = 0, hi = 0;
    for (var i = 0; i < m - 1; i++) {
        if(arr_table_100000[0][i] > 0.5)
            p_j = (5 - Math.sqrt(25 - 10 * arr_table_100000[1][i])) / 2 - (5 - Math.sqrt(25 - 10 * arr_table_100000[0][i])) / 2;
        else
            p_j = arr_table_100000[1][i] - arr_table_100000[0][i];
        hi += Math.pow((arr_table_100000[4][i] - p_j), 2) / p_j;
    }

    hi *= 100000;
    var p_1 = 6.3, p_2 = 10.6, p_3 = 40.3;
    console.log(hi);

    if (hi > p_3)
        console.log("червёртая выборка удовлетворяет условию");
    else
        console.log("червёртая выборка не удовлетворяет условию");


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