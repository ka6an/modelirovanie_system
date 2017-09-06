/// <reference path="jquery.d.ts" />
/// <reference path="google_chart.d.ts" />
google.charts.load('current', {
  'packages': ['corechart']
});

$(document).ready(function() {
  google.charts.setOnLoadCallback(button1_Click);
});

var mas1 = [], mas2 = [], mas3 = [], mas4 = [], mas_1 = [], mas_2 = [], masP = [], select_mas = [],
  N = 30000, M = 100,
  alpha = 0.6, h = 0.02, d, m, s_0, k_f, t_f;

masP[0] = 2.7; masP[1] = 4.6; masP[2] = 6.3; masP[3] = 7.8; masP[4] = 9.2;
masP[5] = 10.6; masP[6] = 12; masP[7] = 13.4; masP[8] = 14.7; masP[9] = 16;
masP[10] = 17.3; masP[11] = 18.5; masP[12] = 19.8; masP[13] = 21.1; masP[14] = 22.3;
masP[15] = 23.5; masP[16] = 24.8; masP[17] = 26; masP[18] = 27.2; masP[19] = 28.4;
masP[20] = 29.6; masP[21] = 30.8; masP[22] = 32; masP[23] = 33.2; masP[24] = 34.4;
masP[25] = 35.6; masP[26] = 36.7; masP[27] = 37.9; masP[28] = 39.4; masP[29] = 39.1;

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
  for (var i = 0; i < N; i++)
    mas3[i] = 1 - (Math.log(1 - mas2[i])) / 4;
}

function DrawGraph_stat_s(mas1, mas2) {
  var data = new google.visualization.DataTable();
  data.addColumn('string', 'Task');
  data.addColumn('number', 'D');
  data.addColumn('number', 'T');
  var options = {
    title: 'График значений',
    explorer: { actions: ["dragToZoom", "rightClickToReset"], maxZoomIn: 1, maxZoomOut: 1 }
  };

  var m1 = [];
  var temp;

  for (var j = 0; j < M; j++) {
    data.addRows([
      [(j / M).toString(), mas1[j], mas2[j]]
    ]);
    if (j != M - 1) {
      data.addRows([
        [(j / M).toString(), mas1[j + 1], mas2[j + 1]]
      ]);
    }
    else {
      data.addRows([
        [(j / M).toString(), mas1[j], mas2[j]]
      ]);
    }
    m1[j] = j / M;
  }
  var chart = new google.visualization.LineChart(document.getElementById("chart_div_1_1"));
  chart.draw(data, options);

  temp = func_max_delta(m1, mas1, mas2, M) * Math.sqrt(M * M / (M + M));
  if (temp > 1.22)
    console.log("Лямбда = " + temp + " --> Не удовлетворяет");
  else
    console.log("Лямбда = " + temp + " --> Удовлетворяет");
}



function DrawGraph_stat_e(mas1, mas2) {
  var data = new google.visualization.DataTable();
  data.addColumn('string', 'Task');
  data.addColumn('number', 'D');
  data.addColumn('number', 'T');
  var options = {
    title: 'График значений',
    explorer: { actions: ["dragToZoom", "rightClickToReset"], maxZoomIn: 100, maxZoomOut: 1 }
  };

  var m1 = [];
  var temp;

  for (var j = 0; j < M; j++) {
    data.addRows([
      [(j / M).toString(), mas1[j], mas2[j]]
    ]);
    if (j != M - 1) {
      data.addRows([
        [(j / M).toString(), mas1[j + 1], mas2[j + 1]]
      ]);
    }
    else {
      data.addRows([
        [(j / M).toString(), mas1[j], mas2[j]]
      ]);
    }
    m1[j] = j / M;
  }
  var chart = new google.visualization.LineChart(document.getElementById("chart_div_1_2"));
  chart.draw(data, options);

  temp = func_max_delta(m1, mas1, mas2, M) * Math.sqrt(M * M / (M + M));
  if (temp > 1.22)
    console.log("Лямбда = " + temp + " --> Не удовлетворяет");
  else
    console.log("Лямбда = " + temp + " --> Удовлетворяет");
}

function func_max_delta(m1, mas1, mas2, n) {
  var delta_1 = 0;
  var count_1 = 0, count_2 = 0;
  while (count_1 + 1 < n || count_2 + 1 < n) {
    var x1 = count_1 + 1 >= n ? 99999 : mas1[count_1 + 1];
    var x2 = count_2 + 1 >= n ? 99999 : mas2[count_2 + 1];
    if (x1 < x2)
      count_1++;
    else
      count_2++;
    delta_1 = Math.max(delta_1, Math.abs(m1[count_1] - m1[count_2]));
  }
  return delta_1;
}

function compareNumeric(a, b) {
  if (a > b) return 1;
  if (a < b) return -1;
}

function button1_Click() {
  d = 1;
  m = 0;
  s_0 = h;
  t_f = 1 / alpha;
  k_f = Math.sqrt((2 * d) / (alpha * s_0));
  var mas_3 = [];
  for (var i = 0; i < M; i++) {
    func_filter();
    func_ravn();
    func_obr_frv();
    mas_1[i] = mas3[1999];
    mas_2[i] = mas3[2999];
  }
  mas_1.sort(compareNumeric);
  mas_2.sort(compareNumeric);
  DrawGraph_stat_s(mas_1, mas_2);
  var shift = 250;
  for (var i = 0; i < M; i++) {
    mas_3[i] = mas3[shift + i*shift];
  }
  mas_3.sort(compareNumeric);
  DrawGraph_stat_e(mas_1, mas_3);
}