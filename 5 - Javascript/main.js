// var fruta = [{nome: "banana", cor: "amarela"}, {nome: "uva", cor: "roxa"}]

// console.log(fruta[0].nome + " " + fruta[0].cor);
// console.log(fruta[1].nome);

// function soma(n1, n2){
//     return n1+n2;
// }

// console.log(soma(1,2));

function clicou(){
    document.getElementById("agradecimento").innerHTML = "<b>Obrigado por clicar</b>";

}

function redirecionar(){
    window.open("https://www.google.com.br");
}


function trocar(element){
    element.innerHTML = "Obrigado por passar o mouse";
}