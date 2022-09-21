
// Solução da atividade 5 com uso do comando "for"

let numeroDealunos =20;
for (let contador =0; contador <= numeroDealunos; contador++)
{
    if(contador==0){
        console.log(`${contador} -Zero!`) // interpolação
                                          //outra forma: console.log(contador +"-Zero!")  concatenação
    } else if( (contador % 2) == 0){
        console.log(`${contador}  é par!`)
    } else{
        console.log(`${contador}  é ímpar!`)
    }
}