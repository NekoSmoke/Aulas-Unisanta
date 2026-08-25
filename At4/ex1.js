//Crie uma função chamada calcular que receba três parâmetros: 
// dois números e uma função callback. 
// A função calcular deve executar a função callback 
// passando os dois números como argumentos e retornar o resultado.
//  Em seguida, crie callbacks para somar, subtrair e multiplicar.
function calcular(num1, num2, kickback) {
    return kickback(num1, num2);
}

function sum(num1,num2) {
    return num1 + num2
}
function sub(num1,num2) {
    return num1 - num2
}
function mult(num1,num2) {
    return num1 * num2
}
console.log(calcular(6,7,sum))
console.log(calcular(6,7,sub))
console.log(calcular(6,7,mult))