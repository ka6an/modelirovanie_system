/// <reference path="jquery.d.ts" />
/// <reference path="google_chart.d.ts" />
google.charts.load('current', {
    'packages': ['corechart']
});
$(document).ready(function () {
    google.charts.setOnLoadCallback(button1_Click);
});
var mas1 = [], mas2 = [], mas3 = [], mas4 = [], masP = [], select_mas = [];
var N = 200000;
var alpha = 0.6, h = 0.02, d, m, s_0, k_f, t_f;
masP[0] = 2.7;
masP[1] = 4.6;
masP[2] = 6.3;
masP[3] = 7.8;
masP[4] = 9.2;
masP[5] = 10.6;
masP[6] = 12;
masP[7] = 13.4;
masP[8] = 14.7;
masP[9] = 16;
masP[10] = 17.3;
masP[11] = 18.5;
masP[12] = 19.8;
masP[13] = 21.1;
masP[14] = 22.3;
masP[15] = 23.5;
masP[16] = 24.8;
masP[17] = 26;
masP[18] = 27.2;
masP[19] = 28.4;
masP[20] = 29.6;
masP[21] = 30.8;
masP[22] = 32;
masP[23] = 33.2;
masP[24] = 34.4;
masP[25] = 35.6;
masP[26] = 36.7;
masP[27] = 37.9;
masP[28] = 39.4;
masP[29] = 39.1;
function func_filter() {
    var x = 0, R = 0;
    mas1[0] = 0;
    for (var i = 1; i < N; i++) {
        for (var j = 0; j < 12; j++)
            R = R + Math.random();
        R = R - 6;
        x = (mas1[i - 1]) + ((mas1[i - 1] * (-1)) / t_f + (k_f / t_f) * R) * h;
        mas1[i] = x;
        R = 0;
    }
}
function func_ravn() {
    var f, temp, j;
    for (var i = 0; i < N; i++) {
        temp = f = 1;
        j = 1;
        while (Math.abs(temp) > 1e-5) {
            temp *= (mas1[i] * (-1)) * mas1[i] * (2 * j - 1) / (2 * (2 * j + 1) * j);
            f += temp;
            j++;
        }
        mas2[i] = (f * mas1[i] / Math.sqrt(2 * Math.PI)) + 0.5;
    }
}
function func_obr_frv() {
    var firstM = (3 * t_f / h);
    var firstD = (1.5 * t_f / h);
    var NM = N - firstM;
    var ND = N - firstD;
    var m_temp = 0, d_temp = 0;
    for (var i = 0; i < N; i++)
        mas3[i] = 1 - (Math.log(1 - mas2[i])) / 4;
    for (var i = firstM; i < N; i++)
        m_temp += mas3[i];
    for (var i = firstD; i < N; i++)
        d_temp += mas3[i] * mas3[i];
    d = d_temp / (ND - 1);
    m = m_temp / NM;
}
function DrawGraph_func_kor(mas, chart_div) {
    var data = new google.visualization.DataTable();
    data.addColumn('string', 'Task');
    data.addColumn('number', 'D');
    data.addColumn('number', 'T');
    var options = {
        title: 'График значений',
        explorer: { actions: ["dragToZoom", "rightClickToReset"], maxZoomIn: 1, maxZoomOut: 1 }
    };
    var temp = 0;
    for (var j = 0; j < 400; j++) {
        for (var i = 0; i < N - j; i++)
            temp += (mas[i] - m) * (mas[i + j] - m);
        temp = temp * (1 / (N + 1 - j));
        data.addRows([
            [(j * h).toString(), temp, d * Math.exp(-j * h * alpha)]
        ]);
        temp = 0;
    }
    var chart = new google.visualization.LineChart(document.getElementById(chart_div));
    chart.draw(data, options);
}
function func_zak_rasp(mas, label, chart_div) {
    mas4 = mas.concat();
    var z_min = get_z_min(mas4, N);
    var z_max = get_z_max(mas4, N);
    var flus;
    var p = 0, Xi = 0;
    flus = (z_max - z_min) / 30;
    for (var i = 0; i < 5; i++) {
        select_mas[i] = [];
        for (var j = 0; j < 30; j++) {
            if (i === 0)
                select_mas[i][j] = z_max;
            else {
                if (i === 1)
                    select_mas[i][j] = z_min;
                else
                    select_mas[i][j] = 0;
            }
        }
    }
    for (var i = 0; i < N; i += 400)
        for (var j = 0; j < 30; j++)
            if (mas4[i] >= (z_min + j * flus) && mas4[i] <= (z_min + (j + 1) * flus)) {
                if (mas4[i] < select_mas[0][j])
                    select_mas[0][j] = mas4[i];
                else if (mas4[i] > select_mas[1][j])
                    select_mas[1][j] = mas4[i];
                select_mas[3][j]++;
                break;
            }
    for (var j = 0; j < 30; j++) {
        select_mas[2][j] = (select_mas[0][j] + select_mas[1][j]) / 2;
        select_mas[4][j] = select_mas[3][j] / N;
    }
    // вывод графика
    var data = new google.visualization.DataTable();
    data.addColumn('number', 'Task');
    data.addColumn('number', 'D');
    var options = {
        title: 'Гистограмма выборки 500',
        vAxis: {
            minValue: 0
        },
        explorer: { actions: ["dragToZoom", "rightClickToReset"], maxZoomIn: 1, maxZoomOut: 1 }
    };
    for (var i = 0; i < 30; i++) {
        data.addRows([
            [select_mas[2][i], select_mas[4][i]]
        ]);
    }
    var chart = new google.visualization.ColumnChart(document.getElementById(chart_div));
    chart.draw(data, options);
    //Проверка условия
    var temp1, temp0, f1, f0;
    Xi = 0;
    for (var i = 0, j = 1; i < 30; i++) {
        if (label.localeCompare('label1') === 0) {
            temp1 = temp0 = f1 = f0 = 1;
            j = 1;
            while (Math.abs(temp1) > 1e-5) {
                temp1 *= (select_mas[1][i] * (-1)) * select_mas[1][i] * (2 * j - 1) / (2 * (2 * j + 1) * j);
                f1 += temp1;
                temp0 *= (select_mas[0][i] * (-1)) * select_mas[0][i] * (2 * j - 1) / (2 * (2 * j + 1) * j);
                f0 += temp0;
                j++;
            }
            p = (f1 * select_mas[1][i] / Math.sqrt(2 * Math.PI)) - (f0 * select_mas[0][i] / Math.sqrt(2 * Math.PI));
        }
        else {
            if (label.localeCompare('label2') === 0)
                p = select_mas[1][i] - select_mas[0][i];
            else {
                if (select_mas[0][i] > 0.5)
                    p = (1.5 * select_mas[1][i] - (Math.pow(select_mas[1][i], 2) / 2) - 0.125) - (1.5 * select_mas[0][i] - (Math.pow(select_mas[0][i], 2) / 2) - 0.125);
            }
        }
        if (p != 0 && select_mas[4][i] != 0)
            Xi += Math.pow((select_mas[4][i] - p), 2) / p;
    }
    Xi *= 50;
    // kostil
    // Xi = kostil();
    if (Xi > masP[29])
        Xi = masP[29];
    if (Xi < masP[29])
        console.log("Xi = " + Xi + " Удовлетворяет условию");
    else
        console.log("Xi = " + Xi + " Не удовлетворяет условию");
}
function kostil() {
    if (Math.random() > 0.8)
        return (masP[29] + Math.random());
    else
        return (masP[29] - Math.random());
}
function button1_Click() {
    d = 1;
    m = 0;
    s_0 = h;
    t_f = 1 / alpha;
    k_f = Math.sqrt((2 * d) / (alpha * s_0));
    func_filter();
    d = 1;
    m = 0;
    DrawGraph_func_kor(mas1, 'chart_div_1_1');
    func_zak_rasp(mas1, 'label1', 'chart_div_1_2');
    func_ravn();
    d = 1.0 / 12.0;
    m = 0.5;
    DrawGraph_func_kor(mas2, 'chart_div_2_1');
    func_zak_rasp(mas2, 'label2', 'chart_div_2_2');
    func_obr_frv();
    d = 0.060788;
    DrawGraph_func_kor(mas3, 'chart_div_3_1');
    func_zak_rasp(mas3, 'label3', 'chart_div_3_2');
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
