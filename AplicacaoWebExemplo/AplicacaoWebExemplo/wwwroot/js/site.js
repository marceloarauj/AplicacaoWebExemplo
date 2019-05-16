// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code

$(document).ready(function () {

    var usuario = $('#chave').html();
    // obter Repositórios do Github

        $.ajax({
            method: 'GET',
            dataType: "json",
            contentType: 'application/json',
            url: 'https://api.github.com/users/' + usuario+ '/repos',
            success: function (response, s) { atualizarTabela(response); },
            error: function (request,status,error) { alert(error);}
        });

        
        
       

    function atualizarTabela(response) {

        for (i = 0; i < response.length; i++){
            $('#reps').append('<tr><td>' + response[i].name + '</td></tr>');
        }
        
    }    
    
    
});

