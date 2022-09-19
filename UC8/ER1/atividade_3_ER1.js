let listaDepecas=[]

 listaDepecas.push('Disco')
 listaDepecas.push('Pneu')
 listaDepecas.push('Amortecedor')

if(listaDepecas.length < 10) { 
   console.log ('É possível cadastrar mais peças')
}else{
   console.log ('Não é possível cadastrar mais peças')
     }

let peso = 150

if (peso < 100){
   console.log ('Peça deve pesar, no mínimo, 100g.')
}else{
   console.log ('Peça com peso adequado')
}
let nomePeca = 'Amortecedor'
if (nomePeca.length > 3){
    console.log ('Nome da peça está adequado')
}else if (nomePeca.length == 0){ 
    console.log ('Nome da peça não pode ser vazio')
}else {
     console.log ('O nome da peça deve ter mais de 3 caracteres.')
}