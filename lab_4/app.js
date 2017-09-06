/// <reference path="jquery.d.ts" />
/// <reference path="google_chart.d.ts" />
google.charts.load('current', {
    'packages': ['corechart']
});
$(document).ready(function () {
    google.charts.setOnLoadCallback(main);
});
function main() {
    var x = 0, mas = [], N = 100000, alpha = 0.6, h = 0.02, s_0, t_f, k_f, D = 5, R;
    s_0 = h / 12;
    t_f = 1 / alpha;
    k_f = Math.sqrt((2 * D) / (alpha * s_0));
    mas[0] = 0;
    for (var i = 1; i < 100000; i++) {
        x = Number(mas[i - 1]) + (Number(mas[i - 1] * (-1)) / Number(t_f) + Number(k_f / t_f) * Number(Math.random() - 0.5)) * Number(h);
        mas[i] = x;
    }
    // var data = google.visualization.arrayToDataTable([
    //           ['Year', 'Sales', 'Expenses'],
    //           ['2004',  1000,      400],
    //           ['2005',  1170,      460],
    //           ['2006',  660,       1120],
    //           ['2007',  1030,      540]
    //         ]);
    var data = new google.visualization.DataTable();
    data.addColumn('string', 'Task');
    data.addColumn('number', 'D');
    data.addColumn('number', 'T');
    var options = {
        title: 'График значений',
        explorer: { actions: ["dragToZoom", "rightClickToReset"], maxZoomIn: 1, maxZoomOut: 1 }
    };
    var temp = 0;
    for (var j = 0; j < 250; j++) {
        for (var i = 0; i < N - j; i++) {
            temp += mas[i] * mas[i + j];
        }
        temp *= 1 / (N + 1 - j);
        data.addRows([
            [(j * h).toString(), temp / 2.5, 2 * Math.exp((-j) * h * alpha)]
        ]);
        temp = 0;
    }
    var chart = new google.visualization.LineChart(document.getElementById("chart_div_1"));
    chart.draw(data, options);
}
