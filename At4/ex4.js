//     Considere o seguinte array referente a
//  valores monetários em real [100, 200, 1050, 625, 348],
//  elabore um programa que solicite ao usuário a cotação do dólar 
// em seguida deve realizar as seguintes etapas:
//A) Converter os valores para dólar.
//B) Separar os valores maiores que U$50,00.
//C) Exibir a soma desses valores no formato U$XXX,XX.
//D) Armazenar esses valores em um novo array no formato U$XXX,XX.
//Obs.: Proibido utilizar as estruturas for, while e do/while

let dinheiros = [100, 200, 1050, 625, 348]
let cotacao = prompt("Digite a cotação do Dolar:")
cotacao = Number(cotacao)

console.log("A)")
dinheiros.forEach(valor => console.log("U$"+(valor/cotacao).toFixed(2)))

console.log("B)")
let bigmoney = dinheiros.filter(valor => (valor/cotacao)>50)
console.log(bigmoney)

console.log("C)")
let valores = []
bigmoney.forEach(valor => valores.push(valor/cotacao))
console.log("U$"+valores.reduce((a,b)=>a+b).toFixed(2))

console.log("D)")
let newarray = []
bigmoney.forEach(valor => newarray.push("U$"+(valor/cotacao).toFixed(2)))
console.log(newarray)
