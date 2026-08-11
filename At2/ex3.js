/* Elabore um programa onde o usuário vai entrar com 10 valores inteiros,
 que devem ser armazenados em um array, após este procedimento o programa deve 
 exibir qual o maior valor e o índice do elemento que armazena este valor.*/
let valores = [];
for (let i = 0; i < 10; i++) {
    valores[i] = parseInt(prompt("Digite o " + (i + 1) + "º valor inteiro:"));
}
let maior = valores[0]
let indice = 0
for (let j = 1; j < valores.length; j++){
    if (valores[j] > maior){
        maior = valores[j]
        indice = j
    }
}
console.log("O maior valor é " + maior + " e está no índice " + indice);