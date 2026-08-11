let nome = prompt("Digite o seu nome completo")
 let nomesplit = nome.split(" ")
 console.log(nomesplit)

 for (let i = 0; i < nomesplit.length; i++){
    if (nomesplit[i] !== "da" && nomesplit[i] !== "de" && nomesplit[i] !== "do" && nomesplit[i] !== "dos" && nomesplit[i] !== "das"){
        console.log(nomesplit[i].charAt(0).toUpperCase() +".")
    }
    
 }