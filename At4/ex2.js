//Crie uma função chamada meuFiltro que receba dois parâmetros:
//  um array de números e uma função callback.
//  A função meuFiltro deve iterar sobre o array original,
//  executar o callback para cada item e, se o callback retornar true,
//  adicionar esse item a um novo array. Retorne o novo array no final.
let numeros = [4004, 345, 554, 7036, 4]
function par(num){
    return num%2 === 0
}
function meuFiltro(arrouca, kickback){
    let fodinhaarray = []
    for(let pintos=0; pintos<arrouca.length;pintos++){
        if(kickback(arrouca[pintos])){
            fodinhaarray.push(arrouca[pintos])
        }
    }
    return fodinhaarray
}
console.log(meuFiltro(numeros, par))