function SetCurrentRowIndexes(th) {
    th.each(function () {
        var index = $(this).closest('tr').index();
        var position = index + 1;
        $(this).text(position);
    });
}

function GetTableRowCount(table) {
    return table.find('tr').length - 1;
}
