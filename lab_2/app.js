/// <reference path="jquery.d.ts" />
var selected_row = '1', selected_col = '1', $selected_val = $('.row_1.col_1').attr('data-z'), $before = $('.before'), $after = $('.after'), $top_p = $('.top p');
function run() {
    selected_col = $('.row_' + selected_row + '.col_' + selected_col).attr('data-z');
    selected_row = $('#select option:selected').val();
    $selected_val = $('.row_' + selected_row + '.col_' + selected_col).attr('data-z');
    $before.css('transform', 'translateY(' + 70 * (Number(selected_row) - 1) + 'px)');
    $after.css('transform', 'translateX(' + 70 * (Number(selected_col) - 1) + 'px)');
    $('.top').children('p').removeClass('red');
    $top_p.each(function () {
        if ($selected_val === $(this).attr('data-z'))
            $(this).addClass('red');
    });
    // console.log('$selected_val = ' + $selected_val + ' selected_col = ' + selected_col);
    $('p.val').html('текущее значение: z' + $selected_val);
    if ($selected_val != '5')
        $('p.exit').html('текущий выход: y' + $selected_val);
    else
        $('p.exit').html('текущий выход: y4');
}
