//Crie uma função chamada calcularIMC que receba dois parâmetros: peso (em quilogramas) e altura (em metros).
//  A função deve calcular e retornar o valor do IMC (fórmula: peso / altura²).
//  Garanta que o valor retornado tenha apenas duas casas decimais.
//  Utilize a função criada e verifique em que faixa de peso a pessoa está de acordo com a imagem abaixo.
function calcularIMC(peso, altura){
    return Number((peso / (altura ** 2)).toFixed(2));
}
let peso = prompt("Digite o seu peso em quilogramas: ")
let altura = prompt("Digite a sua altura em metros: ")
console.log("Seu IMC é: "+calcularIMC(peso, altura))
if (calcularIMC(peso, altura) < 18.5) {
    console.log("Você está abaixo do peso ideal.")
}
else if(calcularIMC(peso, altura) >= 18.5 && calcularIMC(peso, altura) < 25) {
    console.log("Você está com o peso ideal.")
}
else if(calcularIMC(peso, altura) >= 25 && calcularIMC(peso, altura) < 30) {
    console.log("Você está acima do peso ideal.")
}
else {
    console.log("Você está obeso.")
}