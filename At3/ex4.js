//Crie uma função recursiva (uma função que chama a si mesma) 
// chamada calcularFatorial que receba um número inteiro positivo. 
// A função deve retornar o fatorial desse número.

function calcularFatorial(num){
    if (num === 0) {
        return 1;
    } else {
        return num * calcularFatorial(num - 1);
    }
}
let numero = prompt("Digite um numero inteiro positivo: ")
numero = Number(numero)
console.log(calcularFatorial(numero))