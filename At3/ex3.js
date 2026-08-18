//Escreva uma arrow function chamada filtrarPares que receba um array de números inteiros como parâmetro. 
// A função deve retornar um novo array contendo apenas os números pares do array original.
//  Pesquise e tente utilizar o método .filter() nativo dos arrays do JavaScript

const filtrarPares = (arr) => {
    return arr.filter(num => num % 2 === 0);
}
let i = 1
let quantidade = prompt("Quantos numeros você deseja entrar? " )
let numero = []
while (i<=quantidade){
    numero[i] = prompt("Digite o seu "+i+"º numero")
    i++
}
const pares = numero.filter(function(numero){
    return numero % 2 === 0;
})
console.log("A lista de numeros pares é: ")
console.log(pares)