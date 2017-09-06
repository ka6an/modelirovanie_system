/// <reference path="jquery.d.ts" />
var lyamd = 2.5, my = 0.5, alpha_d = 3, eps, t, T, N_treb, q, p, N = 0, M = 0, n = 3, m = 4, k = 0, r = 0;
function func_post(R) {
    return (-1 / lyamd) * Math.log(1 - R);
}
function func_obsl(R) {
    // if (k == 0)
    //     return -1 / my * Math.log(1 - R);
    // else
    return (-1 / (my * k)) * Math.log(1 - R);
}
function func_interv(t, T) {
    while (t < T) {
        var t_i, T_i;
        t_i = func_post(Math.random());
        if (k == 0) {
            N++;
            M++;
            k++;
            t += t_i;
        }
        else {
            T_i = func_obsl(Math.random());
            if (t_i < T_i) {
                N++;
                t += t_i;
                if (k < n) {
                    M++;
                    k++;
                }
                else if (k === n && r < m) {
                    M++;
                    r++;
                }
            }
            else {
                t += T_i;
                if (r == 0)
                    k--;
                else
                    r--;
            }
        }
    }
    q = (N - M) / N;
    p = M / N;
    eps = alpha_d * Math.sqrt((p * (1 - p)) / N);
    if (eps > 0.01)
        N_treb = (alpha_d * alpha_d * p * (1 - p)) / (0.01 * 0.01);
    else
        N_treb = 0;
    return t;
}
function btn_click() {
    if (Number($('#text').val()) > T) {
        T = Number($('#text').val());
        t = func_interv(t, T);
        var temp = N / t;
        console.log("Лямбда : " + N / t);
        console.log("Вероятность приема : " + p);
        if (N_treb != 0) {
            console.log("N требуемое : " + N_treb + "    " + "N текущее : " + N);
            console.log("Требуемое время : " + N_treb / temp);
        }
        else {
            console.log("N требуемое достигрнуто." + "    " + "N текущее : " + N);
            console.log("Требуемое время достигнуто.");
            $('#text').hide(100);
            $('#btn-2').hide(100);
        }
        console.log("До какого интервала времени увеличить интервал, если текущий интервал [0, " + T + "] ?");
        console.log("Эпсилон : " + eps);
    }
    else
        alert("Ошибка");
}
$(document).ready(main);
function main() {
    t = 0;
    T = 100;
    N = 0;
    M = 0;
    k = 0;
    t = func_post(Math.random());
    N++;
    M++;
    t = func_interv(t, T);
    var temp = N / t;
    console.log("Лямбда : " + N / t);
    console.log("Вероятность приема : " + p);
    if (N_treb != 0) {
        console.log("N требуемое : " + N_treb + "    " + "N текущее : " + N);
        console.log("Требуемое время : " + N_treb / temp);
    }
    else {
        console.log("N требуемое достигнуто." + "    " + "N текущее : " + N);
        console.log("Требуемое время достигнуто.");
        $('#text').hide(100);
        $('#btn-2').hide(100);
    }
    console.log("Эпсилон : " + eps);
    console.log("Требуемое время : " + N_treb / temp);
    console.log("До какого интервала времени увеличить интервал, если текущий интервал [0, " + T + "] ?");
}
