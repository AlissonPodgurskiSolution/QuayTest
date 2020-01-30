function sendItem() {
    if (validarCampo()) {
        if ($("#cidade").val() !== "") {
            $.ajax({
                url: "/previsao/GetPrevisoes?parametros=" + $("#cidade").val(),
                type: "GET",
                contentType: "application/json;charset=utf-8",
                dataType: "json",
                data: {
                },
                success: function(data) {
                    $("#cidade").val("");
                    var trHTML = "";
                    $("#tableResults").html(trHTML);
                    $.each(data.listaPrevisaoViewModels,
                        function(i, item) {
                            trHTML += "<tr><td>" +
                                item.DiaFormatado +
                                "</td><td>" +
                                item.Tempo +
                                "</td><td>" +
                                item.Maxima +
                                "°C</td><td>" +
                                item.Minima +
                                "°C</td></tr>";
                        });
                    $("#headerPrevisao").html("Previsão do Tempo para " + data.listaPrevisaoViewModels[0].Cidade);
                    $("#previsaoUF").html("UF: " + data.listaPrevisaoViewModels[0].Estado);
                    $("#previsaoDataConsulta")
                        .html("Data da consulta: " + data.listaPrevisaoViewModels[0].AtualizacaoFormatado);

                    $("#tableResults").append(trHTML);
                    $("#tabelaPrevisao").show();
                }
            });
        }
    }
}

function validarCampo() {
    if ($("#cidade").val().split("/").length !== 3) {
        $("#erro").html("Selecione umas das sugestões para verificar a previsão do tempo.");
        $("#erro").show();
        return false;
    }
    $("#erro").hide();
    return true;
}

$("#cidade").on("keyup",
    function() {

        $.ajax({
            url: "/cidade/GetCidades?Nomecidade=" + $("#cidade").val(),
            type: "GET",
            contentType: "application/json;charset=utf-8",
            dataType: "json",
            success: function(data) {

                var previsaoArray = data.result;
                var previsaoList = {};
                for (var i = 0; i < previsaoArray.length; i++) {
                    var text = previsaoArray[i].Nome +
                        " | UF:" +
                        previsaoArray[i].UF +
                        "</br>" +
                        " /previsao-do-tempo/" +
                        previsaoArray[i].Id;
                    previsaoList[text] = '/Content/images/imagem.png';
                }

                $("#cidade").autocomplete({
                    data: previsaoList,
                    limit: 10,
                    minLength: 3,
                    scrollLength: 2
                });
            }
        });
    });