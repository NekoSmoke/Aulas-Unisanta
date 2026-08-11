let miguel1 = prompt("digite uma string(texto)")
let miguel267 = prompt("digite uma string(texto)")
let miguel3tuff = prompt("digite uma string(texto)")


let miguel = miguel1.trim()
let miguel67 = miguel267.trim()
let migueltuff = miguel3tuff.trim()
let array = [miguel.length,miguel67.length,migueltuff.length]

console.log(array)
console.log(miguel)
console.log(miguel67)
console.log(migueltuff)

    if(array[0] > array[1] && array[0] > array[2]){
        console.log("A maior string é "+miguel)
        if(array[1] > array[2]){
        console.log("A menor string é "+migueltuff)
        }
        else if(array[1] === array[2]) {
            console.log("Os strings "+miguel67+" e "+migueltuff+" Possuem o mesmo tamanho ("+array[1]+")")
        }
        else{
        console.log("A menor string é "+miguel67)
        }
    }
    else if(array[1] > array[0] && array[1] > array[2]){
        console.log("A maior string é "+miguel67)
        if(array[0] > array[2]){
        console.log("A menor string é "+migueltuff)
        }
        else if(array[0] === array[2]) {
            console.log("Os strings "+miguel+" e "+migueltuff+" Possuem o mesmo tamanho ("+array[0]+")")
        }
        else{
        console.log("A menor string é "+miguel)
        }
    }
    else if(array[2] > array[1] && array[2] > array[0]){
        console.log("A maior string é "+migueltuff)
        if(array[1] > array[0]){
        console.log("A menor string é "+miguel)
        }
        else if(array[0] === array[1]) {
            console.log("Os strings "+miguel+" e "+miguel67+" Possuem o mesmo tamanho ("+array[0]+")")
        }
        else{
        console.log("A menor string é "+miguel67)
        }
    }
    else if(array[0] === array[1] ||array[0] === array[2] || array[2] === array[1] ){
        if(miguel === miguel67 && miguel67 === migueltuff){
            console.log("Todas são iguais")
        }
        else if(array [0] === array[1] && miguel === miguel67){
            console.log("As strings 1 e 2 ("+miguel+" e "+miguel67+") sao iguais")
        }
        else if(array [0] === array[2] && miguel === migueltuff){
            console.log("As strings 1 e 3 ("+miguel+" e "+migueltuff+") sao iguais")
        }
        else if(array [2] === array[1] && migueltuff === miguel67){
            console.log("As strings 3 e 2 ("+migueltuff+" e "+miguel67+") sao iguais")
        }
    }
    else {
        console.log("As strings possuem o mesmo tamanho de "+array[0])
    }