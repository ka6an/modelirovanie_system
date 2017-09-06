/// <reference path="jquery.d.ts" />

var lyamd = 2.5, my = 0.5, alpha_d = 3, eps, t, T, N_treb, q, p;
var N = 0, M = 0;

function func_post(R) {
  return -1 / lyamd * Math.log(1 - R);
}
function func_obsl(R) {
  return -1 / my * Math.log(1 - R);
}

function func_interv(t, T) {
  // Random rand = new Random();
  // Console.WriteLine(t + "   " + T);
  while (t < T) {
    var t_i, T_i;
    t_i = func_post(Math.random());
    T_i = func_obsl(Math.random());
    t += t_i;
    //Console.WriteLine(t);
    if (t_i > T_i) {
      N++;
      M++;
    }
    else {
      N++;
    }
  }
  //Console.WriteLine("апрол " + t);
  q = (N - M) / N;
  p = M / N;
  eps = alpha_d * Math.sqrt((q * (1 - q)) / N);
  if (eps > 0.01)
    N_treb = (alpha_d * alpha_d * q * (1 - q)) / (0.01 * 0.01);
  else
    N_treb = 0;
  return t;
}
function button1_Click() {
  // Random rand = new Random();
  t = 0; T = 100; N = 0; M = 0;
  t = func_post(Math.random());
  N++; M++;
  //Console.WriteLine(t);
  t = func_interv(t, T);
  // console.log(N + "  " + M);
  // console.log(p + "  " + q);
  var temp = N / t;
  //Console.WriteLine(N + "  " + t + "  " + temp);
  console.log("Лямбда : " + temp);
  console.log("Вероятность отказа : " + q);
  if (N_treb != 0) {
    console.log("N требуемое : " + N_treb + "    " + "N текущее : " + N);
    console.log("Требуемое время : " + N_treb / temp);
  }
  else {
    console.log("N требуемое достигнуто." + "    " + "N текущее : " + N);
    console.log("Требуемое время достигнуто.");
  }
  console.log("До какого интервала времени увеличить интервал, если текущий интервал [0, " + T + "] ?");
  console.log("Эпсилон : " + eps);

  // textBox1.Visible = true;
  // button2.Visible = true;
}

function button2_Click() {
  // console.log($('#text').val());
  if (Number($('#text').val()) > T) {
    T = Number($('#text').val());
    t = func_interv(t, T);
    // console.log(N + "  " + M);
    // console.log(p + "  " + q);
    var temp = N / t;
    // console.log(N + "  " + t + "  " + temp);
    console.log("Лямбда : " + N / t);
    console.log("Вероятность отказа : " + q);
    if (N_treb != 0)
      console.log("N требуемое : " + N_treb + "    " + "N текущее : " + N);
    else
      console.log("N требуемое достигнуто." + "    " + "N текущее : " + N);
    console.log("До какого интервала времени увеличить интервал, если текущий интервал [0, " + T + "] ?");
    console.log("Эпсилон : " + eps);
    console.log("Требуемое время : " + N_treb / temp);
  }
  else
    alert("Ошибка");
}