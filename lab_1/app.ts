/// <reference path="jquery.d.ts" />
/// <reference path="google_chart.d.ts" />
google.charts.load('current', {
    'packages': ['corechart']
});

var g = 9.81,
    x1 = 0,
    x1_main,
    x2 = 0,
    x3 = 1200,
    c = 4000,
    u = 40,
    h = 9500,
    T = 11,
    r,
    count,
    error;

var arr_1 = [], arr_2 = [], i_5 = 0;

function fun_main() {
    x1 = 0;
    x2 = 0;
    x3 = 1200;
    google.charts.setOnLoadCallback(fun);
}

function fun() {
    var step = Number($('#input_step').val()),
        div_log = $(".log").children('p'),
        x_1, x_2, x_3;

    if (step > 0 && step < T) {
        var data = new google.visualization.DataTable();
        data.addColumn('string', 'Task');
        data.addColumn('number', 'x1');
        data.addColumn('number', 'x2');
        data.addColumn('number', 'x3');
        var options = {
            title: 'График значений',
            hAxis: {
                title: 'интервал'
            },
            vAxis: {
                title: 'значения функций'
            },
            explorer: { actions: ["dragToZoom", "rightClickToReset"], maxZoomIn: .025, maxZoomOut: 10 }
        };

        var num = 1;
        count = T / step;
        var coun = count;
        while (coun >= 100) {
            coun /= 2;
            num *= 2;
        }
        for (var i = 0, i_1 = 0; i <= count; i++) {
            r = 0.1 * Math.pow(Math.E, (x1 / h));
            x_1 = x1 + step * (x2);
            x_2 = x2 + step * ((c * u) / x3 - g - ((r * (x2 * x2)) / x3));
            x_3 = x3 + step * (-u);
            x1 = x_1;
            x2 = x_2;
            x3 = x_3;
            if (i % num === 0) {
                data.addRows([
                    [(i_1 * num * step).toString(), x1, x2, x3]
                ]);
                var k = i_1 * num * step;
                i_1++;
            }
        }
        if (k != T) {
            data.addRows([
                ['11', x1, x2, x3]
            ]);
        }
        var chart = new google.visualization.AreaChart(document.getElementById('chart_div'));
        chart.draw(data, options);
        func_error(step / 2, count * 2, num * 2);
        if (error >= 0.01)
            func_recom_error(step / 4, count * 4, num * 4);
        else {
            console.log('рекомендуемый шаг: ' + step);
            console.log('минимальная погрешность: ' + (error * 100) + '%');
        }

        func_work();

        arr_1[i_5] = step;
        arr_2[i_5] = error * 100;
        i_5 = i_5 + 1;
        func_precition();
    }
}
function func_error(step, count, num) {
    x1_main = x1;
    x1 = 0;
    x2 = 0;
    x3 = 1200;
    var x_1, x_2, x_3;

    var data_1 = new google.visualization.DataTable();
    data_1.addColumn('string', 'Task');
    data_1.addColumn('number', 'x1');

    var options = {
        title: 'График значений_1',
        hAxis: {
            title: 'интервал'
        },
        vAxis: {
            title: 'значения функции'
        },
        explorer: { actions: ["dragToZoom", "rightClickToReset"], maxZoomIn: .025, maxZoomOut: 10 }
    };
    for (var i = 0, i_1 = 0; i <= count; i++) {
        r = 0.1 * Math.pow(Math.E, (x1 / h));
        x_1 = x1 + step * (x2);
        x_2 = x2 + step * ((c * u) / x3 - g - ((r * (x2 * x2)) / x3));
        x_3 = x3 + step * (-u);
        x1 = x_1;
        x2 = x_2;
        x3 = x_3;
        if (i % num === 0) {
            data_1.addRows([
                [(i_1 * num * step).toString(), x1]
            ]);
            var k = i_1 * num * step;
            i_1++;
        }
    }

    if (k != T) {
        data_1.addRows([
            ['11', x1]
        ]);
    }
    error = Math.abs((x1_main - x1) / x1_main);
    console.log('порешность при шаге ' + step * 2 + ' = ' + error * 100 + '%');

    var chart_1 = new google.visualization.AreaChart(document.getElementById('chart_div_1'));
    chart_1.draw(data_1, options);
}

function func_recom_error(step, count, num) {
    var temp_step = step;
    var temp_count = count;
    var temp_num = num;
    while (error >= 0.01) {
        temp_step /= 2;
        temp_count *= 2;
        temp_num *= 2;
        func_error(temp_step, temp_count, temp_num);
    }
    console.log('рекомендуемый шаг: ' + temp_step * 2);
    console.log('минимальная погрешность: ' + (error * 100) + '%');
}

function func_work() {
    var step_cur = T;
    var data_2 = new google.visualization.DataTable();
    data_2.addColumn('string', 'Task');
    data_2.addColumn('number', 'x1');

    var options = {
        title: 'График зависимости трудоёмкости решения от шага интегрирования',
        hAxis: {
            title: 'количество итераций'
        },
        vAxis: {
            title: 'шаг'
        },
        explorer: { actions: ["dragToZoom", "rightClickToReset"], maxZoomIn: .00001, maxZoomOut: 10 }
    };

    while (step_cur >= 0.001) {
        data_2.addRows([
            [(T / step_cur).toString(), step_cur]
        ]);
        step_cur /= 2;
    }

    var chart_2 = new google.visualization.AreaChart(document.getElementById('chart_div_2'));
    chart_2.draw(data_2, options);
}



function func_precition() {

    var data_3 = new google.visualization.DataTable();
    data_3.removeColumns(0, data_3.getNumberOfColumns());
    data_3.addColumn('string', 'Task');
    data_3.addColumn('number', 'x1');

    var options = {
        title: 'График зависимости точности решения от шага интегрирования',
        hAxis: {
            title: 'шаг'
        },
        vAxis: {
            title: 'погрешность'
        },
        explorer: { actions: ["dragToZoom", "rightClickToReset"], maxZoomIn: .00001, maxZoomOut: 10 }
    };
    console.log('i=' + i_5);
    for (var j = 0; j < i_5; j++) {
        data_3.addRows([
            [(arr_1[j]).toString(), arr_2[j]]
        ]);
        console.log(arr_2[j]);
    }
    data_3.sort(0);
    var chart_3 = new google.visualization.AreaChart(document.getElementById('chart_div_3'));
    chart_3.draw(data_3, options);
}