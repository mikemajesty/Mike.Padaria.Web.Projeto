/// <reference path="C:\Users\Mike\documents\visual studio 2013\Projects\Mike.Padaria.Web.Projeto\Padaria.View\Views/Venda/Index.cshtml" />
function ProdurarItensNaComanda() {

    //Data
    var comandaCodigo = $("#Comanda_Codigo").val();

    //Cliente

    /* var token = $('input[name="__RequestVerificationToken"]').val();
     var tokenadr = $('form[action="/Pedido/Create"] input[name="__RequestVerificationToken"]').val();
     var headers = {};
     var headersadr = {};
     headers['__RequestVerificationToken'] = token;
     headersadr['__RequestVerificationToken'] = tokenadr;*/
    var headersadr = {};
    //Gravar
    var url = "/Comanda/GetComanda";

    $.ajax({
        url: url
        , type: "POST"
        , datatype: "json"
        , headers: headersadr
        , data: { ComandaID: 0, Codigo: comandaCodigo }
        , success: function (data) {
            if (data.Codigo > 0) {
                ListarItens(data.Codigo);
            }

            else {



                $.ajax({
                    url: "/Venda/Modal"
       , type: "POST"
       , datatype: "html"
       , headers: headersadr
       , data: {}
       , success: function (data) {
           var divItens = $(data);
           divItens.find('#erro').text("Comanda com o código: " + comandaCodigo + " não existe!");
           divItens.modal();
           divItens.find('#btnConfirmar').click(function () {               
               divItens.modal('hide');
               $('body').removeClass('modal-open');
               $('.modal-backdrop').remove();              
           });

       }


                });

            }
        }

    });

}

function ListarItens(idPedido) {

    var url = "/Comanda/GetItensNaComanda";

    $.ajax({
        url: url
        , type: "GET"
        , data: { comandaCodigo: idPedido }
        , datatype: "html"
        , success: function (data) {
            var divItens = $("#txt1");
            divItens.empty();
            divItens.show();
            divItens.html(data);
        }
    });

}