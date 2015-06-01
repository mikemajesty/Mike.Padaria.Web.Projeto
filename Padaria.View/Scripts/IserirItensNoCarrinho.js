function IserirItensNoCarrinho() {
    var codigo = $('#Produto_Codigo').val();
    var url = "/Comanda/GetProdutosEsomaNoCarrinho";
   
    $.ajax({
           
            url: url,
            type: "Post",
            headers: null,
            data: { Codigo: codigo /*,  Codigo: Codigo, Nome: Nome, PrecoVenda: PrecoVenda, PrecoCompra: PrecoCompra, Quantidade: Quantidade */ },
            success: function (data) {
              
                if (data.ID > 0) {
                    ListarItensProduto(data.ID)
                }
            }
         });

}
function ListarItensProduto(idPedido) {

    var url = "/Comanda/GetProdutoParaInserirNoCarrinho";
    debugger
    $.ajax({
          url: url
        , type: "Get",
          headers: null 
        , data: { ID: idPedido }
        , datatype: "html"
        , success: function (data) {
            debugger
            var divItens = $("#txt2");
            divItens.empty();
            divItens.show();
            divItens.html(data);
        }
    });

}
