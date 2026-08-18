//Crie uma função chamada saudacao que receba como parâmetro um nome (uma string).
//  A função deve retornar uma mensagem de boas-vindas no formato: "Olá, [nome]! Seja muito bem-vindo(a)."
//  Faça com que o parâmetro nome tenha um valor padrão (ex: "Visitante") caso a função seja chamada sem nenhum argumento.
var nome = "Visitante"
function saudacao(nome){
    console.log("Olá, "+nome+"! Seja muito bem-vindo(a).")
}
nome = prompt("Digite seu nome: ", nome)
saudacao(nome)