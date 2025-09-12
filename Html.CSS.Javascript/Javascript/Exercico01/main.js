function operadoresAritmeticos01() {
    let numero1 = parseInt(prompt("Digite o primeiro número:"));
    let numero2 = parseInt(prompt("Digite o segundo número:"));
    let soma = numero1 + numero2;
    alert("A soma é: " + soma);
}

function operadoresAritmeticos02() {
    let numero1 = parseInt(prompt("Digite o primeiro número"));
    let numero2 = parseInt(prompt("Digite o segundo número"));
    let subtrair = numero1 - numero2;
    alert("A difernça é de: " + subtrair);
}

function operadoresAritmeticos03() {
    let numero1 = parseInt(prompt("Digite o primeiro número"));
    let numero2 = parseInt(prompt("Digite o segundo número"));
    let multiplicar = numero1 * numero2;
    alert("A produto é de: " + multiplicar);
}

function operadoresAritmeticos04() {
    let numero1 = parseInt(prompt("Digite o primeiro número"));
    let numero2 = parseInt(prompt("Digite o segundo número"));
    let divisao = numero1 / numero2;
    alert("A divisão é de: " + divisao);
}
  
/*Operadores de Atribuição*/

function operadoresAtribuicao01() {
    let numb = 3456;
    alert("o valor da variável é " + numb);
}

function operadoresAtribuicao02() {
    let numb = 3453;
    alert("o valor da variável é de " + numb);
    let numb2 = parseInt(prompt("Digite o valor para atribuir a variável"));
    let soma = numb + numb2;
    alert("O valor da variável é " + soma);
}

function operadoresAtribuicao03() {
    let numb = 3453;
    alert("o valor da variável é de " + numb);
    let numb2 = parseInt(prompt("Digite o valor para subtrair da variável"));
    let subtrair = numb * numb2;
    alert("O valor da variável é " + subtrair);
}

function operadoresAtribuicao04() {
    let numb = 3400;
    alert("o valor da variável é de " + numb);
    let numb2 = parseInt(prompt("Digite o valor para multiplicar a variável"));
    let dividir = numb * numb2;
    alert("O valor da variável é " + dividir);
}

function operadoresAtribuicao05() {
    let numb = 3400;
    alert("o valor da variável é de " + numb);
    let numb2 = parseInt(prompt("Digite o valor para divisão da variável"));
    let dividir = numb / numb2;
    alert("O valor da variável é " + dividir);
}

/*Operadores de Ralacionais */

function operadorRelacional01() {
    let numb1 = parseInt(prompt("Digite o primeiro valor"));
    let numb2 = parseInt(prompt("Digite o segundo valor"));
    if(numb1 == numb2) {
        alert("Os valores são iguais");
    }else {
        prompt("Os valores são diferentes");
    }
}

function operadorRelacional02() {
    let numb1 = parseInt(prompt("Digite o primeiro valor"));
    let numb2 = parseInt(prompt("Digite o segundo valor"));
    if(numb1 != numb2) {
        alert("Os valores são diferentes");
    }else {
        prompt("Os valores são iguais");
    }
}

function operadorRelacional03() {
    let numb1 = parseInt(prompt("Digite o primeiro valor"));
    let numb2 = parseInt(prompt("Digite o segundo valor"));
    if(numb1 > numb2) {
        alert("O primeiro valor é maior que o segundo");
    }else if (numb1 < numb2){
        alert("O primeiro valor é menor que o segundo");
    }else{
        alert("Os valores são iguais");
    }
}

function operadorRelacional05() {
    let numb1 = parseInt(prompt("Digite o primeiro valor"));
    let numb2 = parseInt(prompt("Digite o segundo valor"));
    if(numb1 < numb2) {
        alert("O primeiro valor é menor que o segundo");
    }else if (numb1 > numb2){
        alert("O primeiro valor é maior que o segundo");
    }else{
        alert("Os valores são iguais");
    }
}

/*Operadores Lógicos*/

function operadorLogico01() {
    let numb1 = parseInt(prompt("Digite o primeiro valor"));
    let numb2 = parseInt(prompt("Digite o segundo valor "));
    if(numb1 > 0 && numb2 > 0 ) {
        alert("ambos os valores são mairores que zero")
    } else {
        alert("ambos ou algum dos dois valores não é maiores que zero")
    }
}

function operadorLogico02() {
    let numb1 = parseInt(prompt("Digite o primeiro valor"));
    let numb2 = parseInt(prompt("Digite o segundo valor "));
    if(numb1 > 0 || numb2 > 0 ) {
        alert("pelo menos um dos valores é mairores que zero")
    } else {
        alert("nenhum dos dois valores não é maiores que zero")
    }
}

/*Operadores Ternários*/ 

function operadorTernario01() {
    let idade = parseInt(prompt("Digite a sua idade"));
    let entrada = (idade >= 18) ? "Maior de idade" : "Menor de idade";
    alert(entrada);
}

function operadorTernario02() {
    let num = parseInt(prompt("Digite o número"));
    let entrada = (num %2==0 ) ? "Numero é par" : "Número é impar";
    alert(entrada);
}

function operadorTernario03() {
    let num = parseInt(prompt("Digite o número"));
    let entrada = (num >=0 ) ? "Numero é Positivo" : "Número é Negativo";
    alert(entrada);
}

