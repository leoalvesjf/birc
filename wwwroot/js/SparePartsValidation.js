﻿function Edit(e, typeEdtion){
        var line = $(e).closest("tr");        
        var id = line.find("td:eq(0)").text().trim();
        var partNumber = line.find("td:eq(1)").text().trim();
        var description = line.find("td:eq(2)").text().trim();
        var value = line.find("td:eq(3)").text().trim();
       /* var quantity = line.find("td:eq(2)").text().trim();*/
        var location = line.find("td:eq(4)").text().trim();
        var po = line.find("td:eq(6)").text().trim();
        var dtIn = line.find("td:eq(5)").text().trim();
        var localUsed = line.find("td:eq(7)").text().trim();
        var userId = line.find("td:eq(8)").text().trim();
        var minimumQuantity = line.find("td:eq(9)").text().trim();



        //remove o ID digitado e a Validação
        document.getElementById('userId').value = "";
        $('[idAlert]').removeClass("is-invalid");

        document.getElementById('quantity').value = "";
        $('[AlertQuantity]').removeClass("is-invalid");

        //Valida se o botão EDIT foi clicado
        let fieldPo = document.getElementById('po').readOnly;
        let fieldLocation = document.getElementById('location').readOnly;
        let fieldLocalUsed = document.getElementById('localUsed').readOnly;

        if (typeEdtion === "minus")
        {            
            if (fieldLocalUsed === true)
            {               
                document.getElementById('localUsed').removeAttribute('readonly');                
            }
        } else if (typeEdtion === "plus")
          {//muda o status dos campos do formularios ativa para edição 
            if ( fieldPo === true|| fieldLocation === true)
            {
                    document.getElementById('po').removeAttribute('readonly');
                    document.getElementById('location').removeAttribute('readonly')
            }                
        } else if (typeEdtion === "edit")
        {
            if ( fieldPo === true||fieldLocalUsed === true )
            {
               document.getElementById('po').removeAttribute('readonly');
               document.getElementById('localUsed').removeAttribute('readonly');
            }
        } else {//muda o status dos campos do formularios para o seu status inicial travados apara edição.
                document.getElementById('po').readOnly = true;
                document.getElementById('localUsed').readonly = true;
                document.getElementById('location').readonly = true;
               } 

        $("#id").val(id);
        $("#partNumber").val(partNumber);
        $("#description").val(description);
        $("#quantity").val(0);
        $("#value").val(value);
        $("#location").val(location);
        $("#po").val(po);
        $("#typeedtion").val(typeEdtion);
        $("#dtIn").val(dtIn);
        $("#localUsed").val(localUsed);
        $("#userId").val(userId);
        $("#minimumQuantity").val(minimumQuantity);
}




function SaveElement()
{
        let data = CreateElement();
        let url = "/SpareParts/EditItem";
        let qtyFormated = 0;

    if (parseInt(data.Quantity) > parseInt(data.Value) && data.TypeEdtion === "minus") {
        $('[AlertQuantity]').addClass("is-invalid");
        return;
    }else {
        document.getElementById('quantity').value = 0;
        $('[AlertQuantity]').addClass("is-invalid");
    }

    if (data.TypeEdtion==="minus")
        qtyFormated = parseInt(data.Value) - parseInt(data.Quantity);
    else
        qtyFormated = parseInt(data.Value) + parseInt(data.Quantity);

        let saveUser = $('#userId').val();
        if (saveUser != ""){
            $.post(url, data, function (resp) {
                let itemId = "[item-id=" + data.Id + "]";
                $(itemId).html(qtyFormated);
                $('[message]').html("Successfully Update");
                $('[messageAlert]').addClass("show");
                $('.modal').modal('hide');
                $('#messageStatus').show();
                setTimeout(function () {
                    $('#messageStatus').hide();
                }, 3500);
             }).fail(function (error) {
                $('[messageAlert]').removeClass("alert-success").addClass("alert-warning").addClass("show");
                $('[message]').html("Erro ao editar" + error.responseText)
                $('#messageStatus').show();
                setTimeout(function () {
                    $('#messageStatus').hide();
                }, 3500);
            });
        }
        else{
                $('[idAlert]').addClass("is-invalid")
        }
}

function CreateElement(){
    return{
    Id: $("#id").val(),
    PartNumber: $("#partNumber").val(),
    Description: $("#description").val(),
    Quantity: $("#quantity").val(),
    Value: $("#value").val(),
    Po: $("#po").val(),
    Location: $("#location").val(),
    DtIn: $("#dtIn").val(),
    TypeEdtion: $("#typeedtion").val(),//tipo de edição minus,plus e edit no modal
    LocalUsed: $("#localUsed").val(),
    userId: $("#userId").val(),
    MinimumQuantity: $("#minimumQuantity").val(),
    };
}
function refreshPage() {
    window.location.reload();
}

/*function verificarCheckBox() {

    var check = document.getElementsByName("checkBoxNewAlbum");

    for (var i = 0; i < check.length; i++) {

        if (check[i].checked == true) {

            // CheckBox Marcado... Faça alguma coisa...

            console.log('Fui marcado');

            document.getElementById("listlocation").style.display = 'none';

            document.getElementById("newlocation").style.display = 'block';

        } else {

            // CheckBox Não Marcado... Faça alguma outra coisa...

            console.log('Fui desmarcado');

            document.getElementById("listlocation").style.display = 'block';

            document.getElementById("newlocation").style.display = 'none';

        }

    }

}
*/