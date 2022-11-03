$(document).ready(function () {
    $("#buttone").click(function () {
        $("#tabela_quadro").btechco_excelexport({
            containerid: "tabela_quadro",
            datatype: $datatype.Table,
            filename: 'Quadro_Operacional'
        });
    });
});