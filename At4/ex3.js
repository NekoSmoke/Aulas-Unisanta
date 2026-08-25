//Crie uma função chamada meuMap que receba um array e uma função callback. 
// A função deve percorrer o array original,
//  executar o callback para cada item
//  e guardar o resultado retornado pelo callback em um novo array.
//  Retorne esse novo array no final.
function meuMap(array,callback){
    let novoarray = []
 for(let pintos=0;pintos<array.length;pintos++){
    if(callback(array[pintos])){
        novoarray.push(callback(array[pintos]))
 }   
}
return novoarray
}
let numeros = [2,3,4,5]
function quad(num){
    return num*num
}
console.log(meuMap(numeros,quad))